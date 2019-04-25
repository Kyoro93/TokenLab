using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokenLab.Control;
using TokenLab.Model;

namespace TokenLab.Vision
{
    public partial class frmInvitesReceived: Form
    {
        public frmInvitesReceived()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            clsDbConnection _db = clsDbConnection.Instance;
            dgvInvitesReceived.DataSource = clsDbConnection.Instance.GetEventsByInvitationReceived(clsClient.Instance.GetUser());
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvitesReceived.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Por favor selecione pelo menos um evento");
                    return;
                }

                if (dgvInvitesReceived.CurrentRow.Cells[5].Value.ToString().Equals("aceito"))
                {
                    MessageBox.Show("Você já aceitou o convite deste evento");
                    return;

                }

                Int32 intQntRows = dgvInvitesReceived.SelectedRows.Count;
                if (MessageBox.Show("Deseja aceitar " + intQntRows + " evento(s)?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow r in dgvInvitesReceived.SelectedRows)
                    {
                        Int32 intIdEvent = Convert.ToInt32(r.Cells[0].Value);
                        string strDescription = r.Cells[1].Value.ToString();
                        string strStartDatetime = r.Cells[2].Value.ToString();
                        string strFinalDatetime = r.Cells[3].Value.ToString();
                        clsEvent ev = new clsEvent(intIdEvent, strDescription, strStartDatetime, strFinalDatetime, clsClient.Instance.GetUser());

                        ev.AcceptInvite(clsClient.Instance.GetUser());
                    }
                    MessageBox.Show("Convite(s) aceito(s) com sucesso.");
                }
                PopulateDataGridView();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao aceitar convite: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvitesReceived.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Por favor selecione pelo menos um evento");
                    return;
                }

                if (dgvInvitesReceived.CurrentRow.Cells[4].Value.ToString().Equals("pendente"))
                {
                    MessageBox.Show("Você já aceitou o convite deste evento");
                    return;

                }

                Int32 intQntRows = dgvInvitesReceived.SelectedRows.Count;
                if (MessageBox.Show("Deseja remover o convite de " + intQntRows + " evento(s)?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow r in dgvInvitesReceived.SelectedRows)
                    {
                        Int32 intIdEvent = Convert.ToInt32(r.Cells[0].Value);
                        string strDescription = r.Cells[1].Value.ToString();
                        string strStartDatetime = r.Cells[2].Value.ToString();
                        string strFinalDatetime = r.Cells[3].Value.ToString();
                        clsEvent ev = new clsEvent(intIdEvent, strDescription, strStartDatetime, strFinalDatetime, clsClient.Instance.GetUser());

                        ev.DeleteInvitation(clsClient.Instance.GetUser());
                    }
                }
                PopulateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
