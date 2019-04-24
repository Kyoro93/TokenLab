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
    public partial class frmLogin : Form
    {
        private bool blLogado;
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            clsDbConnection _db = clsDbConnection.Instance;

            bool result = _db.CheckLogin(txbUser.Text, txbPass.Text);

            this.blLogado = result;

            if(result){
                MessageBox.Show("Seja bem vindo!");
                clsClient _clt = clsClient.Instance;
                _clt.SetLoggedUser(txbUser.Text);
                this.Close();
            }else{
                MessageBox.Show("Usuário ou senha incorreto!");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.blLogado)
            {
                
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            frmNewUser objNewUser = new frmNewUser();
            objNewUser.ShowDialog();
        }

        private void TxbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(this, new EventArgs());
            }
        }
    }
}
