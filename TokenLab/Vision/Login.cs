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
    public partial class Login : Form
    {
        private bool blLogado;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DbConnection _db = DbConnection.Instance;

            bool result = _db.CheckLogin(txbUser.Text, txbPass.Text);

            this.blLogado = result;

            if(result){
                MessageBox.Show("Seja bem vindo!");
                Client _clt = Client.Instance;
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
    }
}
