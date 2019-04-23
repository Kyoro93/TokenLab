using System;
using System.Windows.Forms;
using TokenLab.Control;
using TokenLab.Model;

namespace TokenLab.Vision
{
    public partial class frmAlterPassword : Form
    {
        public frmAlterPassword()
        {
            InitializeComponent();
        }

        private void BtnAlter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbRepeatPass.Text.Equals("") || txbPass.Text.Equals(""))
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
                _db.InsertOrUpdateClient(clsClient.Instance.GetUser() , txbPass.Text);
                MessageBox.Show("Senha alterada com sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar senha: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAlterPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void TxbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAlter_Click(this, new EventArgs());
            }
        }
    }
}
