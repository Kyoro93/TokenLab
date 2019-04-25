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

        public frmEventInsertAlter(clsEvent ev)
        {
            InitializeComponent();

            this.intIdEvent = ev.IntIdEvent;
            rtbDescription.Text = ev.StrDescription;
            dtpStartDate.Text = ev.StrStartDatetime.ToString();
            dtpFinalDate.Text = ev.StrFinalDatetime.ToString();
            mtbStartTime.Text = ev.StrStartDatetime.Substring(11,5);
            mtbFinalTime.Text = ev.StrFinalDatetime.Substring(11,5);
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
                string strDescription = rtbDescription.Text;

                clsEvent ev = new clsEvent(intIdEvent, strDescription, strStartDatetime, strFinalDatetime, clsClient.Instance.GetUser());
                ev.CreateOrUpdateEventOnDb();
                
                this.Close();
            }catch(FormatException fEx)
            {
                MessageBox.Show("Data incorreta, por favor corrija e tente novamente");
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao gerenciar evento: " + ex.Message);
            }
        }

        private void ControlDates(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(dtpStartDate.Value) > Convert.ToDateTime(dtpFinalDate.Value))
                {
                    dtpFinalDate.Text = dtpStartDate.Text;
                    return;
                }
                if (Convert.ToDateTime(dtpFinalDate.Value) < Convert.ToDateTime(dtpStartDate.Value))
                {
                    dtpStartDate.Text = dtpFinalDate.Text;
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
