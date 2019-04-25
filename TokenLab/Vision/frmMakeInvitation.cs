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
    public partial class frmMakeInvitation : Form
    {
        private clsEvent ev;
        public frmMakeInvitation(clsEvent ev)
        {
            InitializeComponent();
            this.ev = ev;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInvite_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbAccessTo.Text.Equals("") || !clsClient.Instance.UserExist(txbAccessTo.Text))
                {
                    MessageBox.Show("Verifique o nome do usuário e tente novamente.");
                    return;
                }
                if (txbAccessTo.Text.Equals(clsClient.Instance.GetUser()))
                {
                    MessageBox.Show("Você já é o dono desse evento.");
                    return;
                }
                if (ev.CheckInvite(txbAccessTo.Text)){
                    MessageBox.Show("Este usuário já possui um convite para este evento.");
                    return;
                }


                ev.InviteToEvent(txbAccessTo.Text);

                MessageBox.Show("Usuario convidado com sucesso");
                if (MessageBox.Show("Deseja convidar mais usuários para este evento?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txbAccessTo.Text = "";
                    return;
                }
                this.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao convidar: " + ex.Message);
            }
        }
    }
}
