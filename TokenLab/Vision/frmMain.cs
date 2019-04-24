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
using TokenLab.Vision;

namespace TokenLab
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void HideUnwantedDgvColumns()
        {
            dgvEvent.Columns["txbIdEvent"].Visible = false;
            dgvEvent.Columns["txbOwnerLogin"].Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmLogin objLogin = new frmLogin();
            objLogin.ShowDialog();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            dgvEvent.DataSource = clsDbConnection.Instance.GetEventsByOwner(clsClient.Instance.GetUser());
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            frmAlterPassword objAlterPassword = new frmAlterPassword();
            objAlterPassword.ShowDialog();
        }

        private void BtnNewEvent_Click(object sender, EventArgs e)
        {
            frmEventInsertAlter objEventInsertAlter = new frmEventInsertAlter();
            objEventInsertAlter.ShowDialog();
            PopulateDataGridView();
        }

        private void BtnAlterEvent_Click(object sender, EventArgs e)
        {
            if (dgvEvent.SelectedRows.Count > 1) {
                MessageBox.Show("Por favor selecione apenas 1 evento");
                return;
            }

            if(dgvEvent.SelectedRows.Count < 1)
            {
                MessageBox.Show("Por favor selecione pelo menos um evento");
                return;
            }

            string strOwner = dgvEvent.SelectedRows[0].Cells[4].Value.ToString();
            if (!clsClient.Instance.GetUser().Equals(strOwner))
            {
                MessageBox.Show("Você não pode alterar um evento que não é seu");
                return;
            }

            Int32 intIdEvent = Convert.ToInt32(dgvEvent.SelectedRows[0].Cells[0].Value);
            string strDescription = dgvEvent.SelectedRows[0].Cells[1].Value.ToString();
            string strStartDatetime = dgvEvent.SelectedRows[0].Cells[2].Value.ToString();
            string strFinalDatetime = dgvEvent.SelectedRows[0].Cells[3].Value.ToString();

            clsEvent ev = new clsEvent(intIdEvent, strDescription, strStartDatetime, strFinalDatetime, clsClient.Instance.GetUser());

            frmEventInsertAlter objEventInsertAlter = new frmEventInsertAlter(ev);
            objEventInsertAlter.ShowDialog();
            PopulateDataGridView();
        }

        private void BtnDelEvent_Click(object sender, EventArgs e)
        {
            Int32 intQntRows = dgvEvent.SelectedRows.Count;

            foreach (DataGridViewRow r in dgvEvent.SelectedRows)
            {
                string strOwner = r.Cells[4].Value.ToString();

                if (!clsClient.Instance.GetUser().Equals(strOwner))
                {
                    MessageBox.Show("Você não pode remover um evento que não é seu");
                    return;
                }
            }

            if (MessageBox.Show("Deseja remover " + intQntRows + " evento(s)?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow r in dgvEvent.SelectedRows)
                    {
                        Int32 intIdEvent = Convert.ToInt32(r.Cells[0].Value);
                        string strDescription = dgvEvent.SelectedRows[0].Cells[1].Value.ToString();
                        string strStartDatetime = dgvEvent.SelectedRows[0].Cells[2].Value.ToString();
                        string strFinalDatetime = dgvEvent.SelectedRows[0].Cells[3].Value.ToString();
                        clsEvent ev = new clsEvent(intIdEvent, strDescription, strStartDatetime, strFinalDatetime, clsClient.Instance.GetUser());
                        ev.DeleteEventFromDb();
                    }

                    PopulateDataGridView();
                }catch(Exception ex)
                {
                    MessageBox.Show("Erro ao deletar evento: " + ex.Message);
                }
            }
        }

        private void BtnInvite_Click(object sender, EventArgs e)
        {
            if (dgvEvent.SelectedRows.Count > 1)
            {
                MessageBox.Show("Por favor selecione apenas 1 evento");
                return;
            }

            if (dgvEvent.SelectedRows.Count < 1)
            {
                MessageBox.Show("Por favor selecione pelo menos um evento");
                return;
            }
            string strOwner = dgvEvent.CurrentRow.Cells[4].Value.ToString();

            if (!clsClient.Instance.GetUser().Equals(strOwner))
            {
                MessageBox.Show("Você não pode convidar alguém para um evento que não é seu");
                return;
            }

            Int32 intIdEvent = Convert.ToInt32(dgvEvent.CurrentRow.Cells[0].Value);
            string strDescription = dgvEvent.SelectedRows[0].Cells[1].Value.ToString();
            string strStartDatetime = dgvEvent.SelectedRows[0].Cells[2].Value.ToString();
            string strFinalDatetime = dgvEvent.SelectedRows[0].Cells[3].Value.ToString();
            clsEvent ev = new clsEvent(intIdEvent, strDescription, strStartDatetime, strFinalDatetime, clsClient.Instance.GetUser());
            frmGiveAccess objGiveAccess = new frmGiveAccess(ev);
            objGiveAccess.ShowDialog();
        }

        private void BtnInvited_Click(object sender, EventArgs e)
        {
            try
            {
                frmInvites objInvites = new frmInvites();
                objInvites.ShowDialog();
                PopulateDataGridView();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar convites: " + ex.Message);
            }
        }

        private void SAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja sair do sistema?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
