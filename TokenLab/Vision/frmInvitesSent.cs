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
    public partial class frmInvitesSent : Form
    {
        public frmInvitesSent()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void PopulateDataGridView()
        {
            clsDbConnection _db = clsDbConnection.Instance;
            dgvInvitesSent.DataSource = clsDbConnection.Instance.GetEventsByInvitationSent(clsClient.Instance.GetUser());
        }

        private void BrnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvitesSent.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Por favor selecione pelo menos um evento");
                    return;
                }

                Int32 intQntRows = dgvInvitesSent.SelectedRows.Count;

                if (MessageBox.Show("Deseja remover o convite de " + intQntRows + " evento(s)?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow r in dgvInvitesSent.SelectedRows)
                    {
                        Int32 intIdEvent = Convert.ToInt32(r.Cells[0].Value);
                        string strDescription = r.Cells[1].Value.ToString();
                        string strStartDatetime = r.Cells[2].Value.ToString();
                        string strFinalDatetime = r.Cells[3].Value.ToString();
                        string strAccessTo = r.Cells[5].Value.ToString();
                        clsEvent ev = new clsEvent(intIdEvent, strDescription, strStartDatetime, strFinalDatetime, clsClient.Instance.GetUser());

                        ev.DeleteInvitation(strAccessTo);
                    }
                    MessageBox.Show("Convite(s) excluido(s) com sucesso.");
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
