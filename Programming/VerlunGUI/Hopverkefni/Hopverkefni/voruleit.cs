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
    public partial class Voruleit : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        string getart = null;
        //
        int heildarverdid = 0, samtals = 0;
        //
        public Voruleit()
        {
            InitializeComponent();
            gagnagrunnur.TengingVidGagnagrunn();

        }

        private void Voruleit_Load(object sender, EventArgs e)
        {
            Allar_Vorur();
        }

        public void Allar_Vorur()
        {
            ListView_voruleit_leitargluggi.Columns.Add("Artnúmer", 60);
            ListView_voruleit_leitargluggi.Columns.Add("Vara", 380);
            ListView_voruleit_leitargluggi.Columns.Add("Verð", 60);

            List<string> linur = new List<string>();

            string[] arr = new string[4];
            ListViewItem itm;

            try
            {
                linur = gagnagrunnur.Voruleit();

                foreach (string lin in linur)
                {
                    string[] LinaUrLista = lin.Split(':');
                    string nafn = LinaUrLista[1];
                    string artnr = LinaUrLista[0];
                    string verd = LinaUrLista[2];

                    arr[0] = artnr;
                    arr[1] = nafn;
                    arr[2] = verd;

                    itm = new ListViewItem(arr);
                    ListView_voruleit_leitargluggi.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_voruleit_leita_Click(object sender, EventArgs e)
        {
            ListView_voruleit_leitargluggi.Clear();
            string leitarorð = tb_voruleit_leitardalkur.Text;
            ListView_voruleit_leitargluggi.Columns.Add("Artnúmer", 60);
            ListView_voruleit_leitargluggi.Columns.Add("Vara", 380);
            ListView_voruleit_leitargluggi.Columns.Add("Verð", 60);

            List<string> linur = new List<string>();

            string[] arr = new string[4];
            ListViewItem itm;

            try
            {
                linur = gagnagrunnur.Leitarorð(leitarorð);

                foreach (string lin in linur)
                {
                    string[] LinaUrLista = lin.Split(':');
                    string nafn = LinaUrLista[1];
                    string artnr = LinaUrLista[0];
                    string verd = LinaUrLista[2];

                    arr[0] = artnr;
                    arr[1] = nafn;
                    arr[2] = verd;

                    itm = new ListViewItem(arr);
                    ListView_voruleit_leitargluggi.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_voruleit_LokaGlugga_Click(object sender, EventArgs e)
        {
            AdalGuggi adalgluggi = new AdalGuggi();
            adalgluggi.Show();
            this.Close();

        }

        private void bt_voruleit_veljaVoru_Click(object sender, EventArgs e)
        {
            string art = getart;
            string[] row = { "1", ";", gagnagrunnur.GetVaraFromArt(art), ";", gagnagrunnur.GetVaraVerdFromArt(art) };

            //
            samtals = samtals + Convert.ToInt32(row[4]);
            heildarverdid = samtals;
            //
            var listViewItem = new ListViewItem(row);
            Setja_I_Skra(row);
            AdalGuggi adalgluggi = new AdalGuggi();//getart er artnumerið sem er sott i linu sem er valið
            adalgluggi.Show();
            this.Close();
        }

        private void ListView_voruleit_leitargluggi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valinlína = null;
            if (ListView_voruleit_leitargluggi.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intSelectIndex = ListView_voruleit_leitargluggi.SelectedIndices[0];
            if (intSelectIndex >= 0)
            {
                valinlína = ListView_voruleit_leitargluggi.SelectedItems[0].Text;
            }
            getart = valinlína;
            
            /*
            string[] row = { "1", gagnagrunnur.GetVaraFromArt(getart), gagnagrunnur.GetVaraVerdFromArt(getart) };
            var listViewItem = new ListViewItem(row);
            list_adalgluggi_kerra.Items.Add(listViewItem);
             */

        }
        private void Setja_I_Skra(string[] x)
        {
            int tel = 1;
            try
            {
                StreamWriter skrifari = File.AppendText("karfa.txt");
                foreach (var item in x)
                {
                    skrifari.Write(item);
                    if (tel % 5 == 0)
                    {
                        skrifari.WriteLine();
                    }
                    tel++;
                }
                skrifari.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Villa 1(textaskrá opnast ekki)" + ex);
            }
        }
        }
    }

