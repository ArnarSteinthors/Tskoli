using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hopverkefni
{
    /*
     * Hópverkefni Önn 3
     * Arnar Daði og Elvar Snær
     * Byjrað 17.11.16
     */
    public partial class Form1 : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        string passw = null;
        public Form1()
        {
            gagnagrunnur.TengingVidGagnagrunn();
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            label_login.Text = "";
            if (tb_password.Text == passw)
            {
                AdalGuggi adalgluggi;
                adalgluggi = new AdalGuggi();
                this.Hide();
                StreamWriter skrifari = File.CreateText("karfa.txt");
                skrifari.Close();
                adalgluggi.Show();
                label_login.Text = "";
               // Environment.Exit(-1);lokar öllu 
            }
            else 
            {
                label_login.Text = "Rangt Lykilorð";
            }
          

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllirNotendur();
        }

        public void AllirNotendur()
        {
            list_login.Columns.Add("ID", 40);
            list_login.Columns.Add("Veldu Notanda", 222);

            List<string> linur = new List<string>();

            string[] arr = new string[4];
            ListViewItem itm;

            try
            {
                linur = gagnagrunnur.LesaNotendur();

                foreach (string lin in linur)
                {
                    string[] LinaUrLista = lin.Split(':');
                    string nafn = LinaUrLista[1];
                    string id = LinaUrLista[0];

                    arr[0] = id;
                    arr[1] = nafn;

                    itm = new ListViewItem(arr);
                    list_login.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void list_login_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getNafn = null;
            if (list_login.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intSelectIndex = list_login.SelectedIndices[0];
            if (intSelectIndex >= 0)
            {
                getNafn = list_login.SelectedItems[0].Text;
                passw = gagnagrunnur.GetPassword(getNafn);
            }

            List<string> linur = new List<string>();

            string[] arr = new string[4];
//          ListViewItem itm;
            try
            {
                gagnagrunnur.GetPassword(getNafn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void list_login_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string getNafn = null;
            if (list_login.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intSelectIndex = list_login.SelectedIndices[0];
            if (intSelectIndex >= 0)
            {
                getNafn = list_login.SelectedItems[0].Text;
                passw = gagnagrunnur.GetPassword(getNafn);
            }

            List<string> linur = new List<string>();

            string[] arr = new string[4];
            //          ListViewItem itm;
            try
            {
                gagnagrunnur.GetPassword(getNafn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_form1_LokaApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        
    }
}
