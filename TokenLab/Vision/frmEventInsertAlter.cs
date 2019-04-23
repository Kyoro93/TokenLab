using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokenLab.Control;
using TokenLab.Model;

namespace TokenLab.Vision
{
    public partial class frmEventInsertAlter : Form
    {
        private Int32 intIdEvent;
        public frmEventInsertAlter()
        {
            InitializeComponent();
        }

        public frmEventInsertAlter(Int32 intIdEvent, string strDescription, string strStartDatetime, string strFinalDatetime)
        {
            InitializeComponent();

            this.intIdEvent = intIdEvent;
            rtbDescription.Text = strDescription;
            dtpStartDate.Text = strStartDatetime.ToString();
            dtpFinalDate.Text = strFinalDatetime.ToString();
            mtbStartTime.Text = strStartDatetime.Substring(11,5);
            mtbFinalTime.Text = strFinalDatetime.Substring(11,5);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                clsDbConnection _db = clsDbConnection.Instance;

                string strStartDatetime = Convert.ToDateTime(dtpStartDate.Text).ToString("yyyy-MM-dd") + " " + mtbStartTime.Text + ":00";
                string strFinalDatetime = Convert.ToDateTime(dtpFinalDate.Text).ToString("yyyy-MM-dd") + " " + mtbFinalTime.Text + ":00";
                DateTime dttStart = Convert.ToDateTime(strStartDatetime);
                DateTime dttFinal = Convert.ToDateTime(strFinalDatetime);

                if (DateTime.Compare(dttStart, dttFinal) > 0) {
                    MessageBox.Show("A data final deve vir cronologicamente depois da data inicial");
                    return;
                }
                if(DateTime.Compare(dttStart, dttFinal) == 0)
                {
                    MessageBox.Show("As datas devem ser diferentes");
                    return;
                }
                if(_db.GetEventNumberByPeriodAndOwner(intIdEvent, strStartDatetime, strFinalDatetime, clsClient.Instance.GetUser()) > 0)
                {
                    MessageBox.Show("Já existem eventos cadastrados pra esse período, por favor selecione outro");
                    return;
                }

                _db.InsertOrUpdateEvent(intIdEvent, rtbDescription.Text, strStartDatetime, strFinalDatetime);
                this.Close();
            }catch(FormatException fEx)
            {
                MessageBox.Show("Data incorreta, por favor corrija e tente novamente");
            }catch(Exception ex)
            {
                throw (ex);
            }
        }

        private void FrmEventInsertAlter_Load(object sender, EventArgs e)
        {

        }
    }
}
