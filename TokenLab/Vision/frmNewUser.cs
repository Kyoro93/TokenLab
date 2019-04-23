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

namespace TokenLab.Vision
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbRepeatPass.Text.Equals("") || txbPass.Text.Equals("") || txbUser.Text.Equals(""))
                {
                    MessageBox.Show("Existem campos em branco");
                    return;
                }
                if (!txbPass.Text.Equals(txbRepeatPass.Text))
                {
                    MessageBox.Show("As senhas não são iguais");
                    return;
                }

                clsDbConnection _db = clsDbConnection.Instance;
                _db.InsertOrUpdateClient(txbUser.Text, txbPass.Text);
                MessageBox.Show("Usuário cadastrado com sucesso, por favor realize o login");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar usuário: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnRegister_Click(this, new EventArgs());
            }
        }
    }
}
