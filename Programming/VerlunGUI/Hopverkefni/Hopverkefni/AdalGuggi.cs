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
    public partial class AdalGuggi : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        Voruleit voruleit = new Voruleit();
        int samtals = 0;
        string voruheiti = null;
       // Voruleit voruleit = new Voruleit("konni");
        List<int> Heildarverð = new List<int>();
        List<string> simaskra = new List<string>();//textpad skrá

        public AdalGuggi()
        {
            InitializeComponent();
            gagnagrunnur.TengingVidGagnagrunn();
            Lesa_Ur_Skra();
        }

        private void AdalGuggi_Load(object sender, EventArgs e)
        {
             Heildarverð.Clear();
            Form1 form1 = new Form1();
            form1.Hide();
            Innkaupskerra();
            //heildarverd = Convert.ToInt32(label_heildarverd_verd.Text);
            
            list_adalgluggi_kerra.Items.Clear();
            Lesa_Ur_Skra();
            label_heildarverd_verd.Text = Heildarverð.Sum().ToString();
        
            
          
        }

        private void bt_adalgluggi_numbpad_1_Click(object sender, EventArgs e)
        {
            rtb_adalgluggi_numpad.Text += "1";
        }

        private void bt_adalgluggi_numbpad_2_Click(object sender, EventArgs e)
        {
            rtb_adalgluggi_numpad.Text += "2";
        }

        private void bt_adalgluggi_numbpad_3_Click(object sender, EventArgs e)
        {
            rtb_adalgluggi_numpad.Text += "3";
        }

        private void bt_adalgluggi_numbpad_4_Click(object sender, EventArgs e)
        {
            rtb_adalgluggi_numpad.Text += "4";
        }

        private void bt_adalgluggi_numbpad_5_Click(object sender, EventArgs e)
        {
            rtb_adalgluggi_numpad.Text += "5";
        }

        private void bt_adalgluggi_numbpad_6_Click(object sender, EventArgs e)
        {
            rtb_adalgluggi_numpad.Text += "6";
        }

        private void bt_adalgluggi_numbpad_7_Click(object sender, EventArgs e)
        {
            rtb_adalgluggi_numpad.Text += "7";
        }

        private void bt_adalgluggi_numbpad_8_Click(object sender, EventArgs e)
        {
            rtb_adalgluggi_numpad.Text += "8";
        }

        private void bt_adalgluggi_numbpad_9_Click(object sender, EventArgs e)
        {
            rtb_adalgluggi_numpad.Text += "9";
        }


        public void Innkaupskerra()
        {
            list_adalgluggi_kerra.Columns.Add("Magn", 46);
            list_adalgluggi_kerra.Columns.Add("Vara", 215);
            list_adalgluggi_kerra.Columns.Add("Verð", 70);
        }
        

        private void bt_adalgluggi_skyr_hreint_Click(object sender, EventArgs e)
        { 
            /*
            string voruheiti = "SKYR Hreint";
            List<string> linur = new List<string>();

            string[] arr = new string[4];
            ListViewItem itm;

            try
            {
                linur = gagnagrunnur.GetVara(voruheiti);

                foreach (string lin in linur)
                {
                    string[] LinaUrLista = lin.Split(':');
                    string nafn = LinaUrLista[1];
                    string id = LinaUrLista[0];

                    arr[0] = id;
                    arr[1] = nafn;

                    itm = new ListViewItem(arr);
                    list_adalgluggi_kerra.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
             */

            
            voruheiti = "SKYR Hreint";
            Bætavöruí();
            
        }

        private void bt_adalgluggi_skyr_jardarber_Click(object sender, EventArgs e)
        {
            voruheiti = "SKYR Jarðaber";
            Bætavöruí();
        }

        private void bt_adalgluggi_skyr_banana_Click(object sender, EventArgs e)
        {
            voruheiti = "SKYR Banana";
            Bætavöruí();
        }

        private void bt_adalgluggi_skyr_blaber_Click(object sender, EventArgs e)
        {
            voruheiti = "SKYR Bláber";
            Bætavöruí();
        }

        private void bt_adalgluggi_skyr_pera_Click(object sender, EventArgs e)
        {
            voruheiti = "SKYR Perur";
            Bætavöruí();
        }

        private void bt_adalgluggi_skyr_blaoghind_Click(object sender, EventArgs e)
        {
            voruheiti = "SKYR BLáber og Hindber";
            Bætavöruí();
        }

        private void bt_adalgluggi_skyr_epli_Click(object sender, EventArgs e)
        {
            voruheiti = "SKYR Bökuð Epli";
            Bætavöruí();
        }

        private void bt_adalgluggi_skyr_sitrona_Click(object sender, EventArgs e)
        {
            voruheiti = "SKYR Sítrónusæla";
            Bætavöruí();
        }

        private void bt_adalgluggi_skyr_sukkuladi_Click(object sender, EventArgs e)
        {
            voruheiti = "SKYR Dökkt Súkkulaði og vanilla";
            Bætavöruí();
        }

        private void bt_adalgluggi_skyr_vanilla_Click(object sender, EventArgs e)
        {
            voruheiti = "SKYR Vanilla";
            Bætavöruí();
        }

        private void bt_adalgluggi_mjolk_lett_Click(object sender, EventArgs e)
        {
            voruheiti = "Léttmjólk 1 L";
            Bætavöruí();
        }

        private void bt_adalgluggi_mjolk_fjor_Click(object sender, EventArgs e)
        {
            voruheiti = "Fjörmjólk 1 L";
            Bætavöruí();
        }

        private void bt_adalgluggi_Kartoflur300g_Click(object sender, EventArgs e)
        {
            voruheiti = "Kartöflur 300 g";
            Bætavöruí();
        }

        private void bt_adalgluggi_sætar_kartöflur300g_Click(object sender, EventArgs e)
        {
            voruheiti = "Sætar Kartöflur 300 g";
            Bætavöruí();
        }

        private void bt_adalgluggi_gulrætur_poki200g_Click(object sender, EventArgs e)
        {
           voruheiti = "Gulrætur Poki 200 g";
            Bætavöruí();
        }

        private void bt_adalgluggi_Laukur_heill_Click(object sender, EventArgs e)
        {
            voruheiti = "Laukur Heill";
            Bætavöruí();
        }

        private void bt_adalgluggi_Blaðlaukur200g_Click(object sender, EventArgs e)
        {
            voruheiti = "Blaðlaukur 200 g";
            Bætavöruí();
        }

        private void bt_adalgluggi_blómkál_Click(object sender, EventArgs e)
        {
            voruheiti = "Blómkál";
            Bætavöruí();
        }

        private void bt_adalgluggi_Rauðrófa_Click(object sender, EventArgs e)
        {
            voruheiti = "Rauðrófa";
            Bætavöruí();
        }

        private void bt_adalgluggi_Tómatur_Stór_Click(object sender, EventArgs e)
        {
            voruheiti = "Tómatur stór";
            Bætavöruí();
        }

        private void bt_adalgluggi_Tómatur_litlir_pakki_Click(object sender, EventArgs e)
        {
            voruheiti = "Tómatar litlir pakki";
            Bætavöruí();
        }

        private void bt_adalgluggi_Agurka_Click(object sender, EventArgs e)
        {
            voruheiti = "Agúrka";
            Bætavöruí();
        }

        private void bt_adalgluggi_Agurka_litil_Click(object sender, EventArgs e)
        {
            voruheiti = "Agúrka lítil";
            Bætavöruí();
        }

        private void bt_adalgluggi_Paprika_Click(object sender, EventArgs e)
        {

            voruheiti = "Paprika";
            Bætavöruí();
        }

        private void bt_adalgluggi_haribo_stjarna_Click(object sender, EventArgs e)
        {
            voruheiti = "Haribo Stjörnu Mix";
            Bætavöruí();
        }

        private void bt_adalgluggi_haribo_bangsar_Click(object sender, EventArgs e)
        {
            voruheiti = "Haribo Bangsar";
            Bætavöruí();
        }

        private void bt_adalgluggi_haribo_fizzycola_Click(object sender, EventArgs e)
        {
            voruheiti = "Haribo Fizzy Cola";
            Bætavöruí();
        }

        private void bt_adalgluggi_haribo_Goldbears_Click(object sender, EventArgs e)
        {
            voruheiti = "Haribo Goldbears";
            Bætavöruí();
        }

        private void bt_adalgluggi_haribo_twist_Click(object sender, EventArgs e)
        {
            voruheiti = "Haribo Twists";
            Bætavöruí();
        }

        private void bt_adalgluggi_haribo_smurfs_Click(object sender, EventArgs e)
        {
            voruheiti = "Haribo Smurfs";
            Bætavöruí();
        }

        private void bt_adalgluggi_Lakkris_Click(object sender, EventArgs e)
        {
            voruheiti = "Lakkrís";
            Bætavöruí();
        }

        private void bt_adalgluggi_Reimar_Lakkris_Click(object sender, EventArgs e)
        {
            voruheiti = "Reimar Lakkrís";
            Bætavöruí();
        }

        private void bt_adalgluggi_Reimar_Fylltar_Lakkris_Click(object sender, EventArgs e)
        {
            voruheiti = "Reimar Fylltar Lakkrís";
            Bætavöruí();
        }

        private void bt_adalgluggi_Pipar_Perlur_Click(object sender, EventArgs e)
        {
            voruheiti = "Pipar perlur";
            Bætavöruí();
        }

        private void bt_adalgluggi_Sukkulaði_Rusinur_Click(object sender, EventArgs e)
        {
            voruheiti = "Súkkulaði rúsínur";
            Bætavöruí();
        }

        private void bt_adalgluggi_Sukkulaði_dökkt_rusinur_Click(object sender, EventArgs e)
        {
            voruheiti = "Súkkulaði dökkt rúsínur";
            Bætavöruí();
        }

        private void bt_adalgluggi_Pepsi2L_Click(object sender, EventArgs e)
        {
            voruheiti = "Pepsi 2 L";
            Bætavöruí();
        }

        private void bt_adalgluggi_PepsiMax2L_Click(object sender, EventArgs e)
        {
            voruheiti = "Pepsi Max 2 L";
            Bætavöruí();
        }

        private void bt_adalgluggi_PepsiMaxHalfurL_Click(object sender, EventArgs e)
        {
            voruheiti = "Pepsi Max 0.5 L";
            Bætavöruí();
        }

        private void bt_adalgluggi_ChigaoTownPizza2stk_Click(object sender, EventArgs e)
        {
            voruheiti = "Chichago Town Pizza 2stk";
            Bætavöruí();
        }

        private void bt_adalgluggi_Euro_Shopper_Pizza_Click(object sender, EventArgs e)
        {
            voruheiti = "Euro Shopper Pizza";
            Bætavöruí();
        }

        private void Frosnar_Franskar500g_Click(object sender, EventArgs e)
        {
            voruheiti = "Frosnar Fransar 500 g";
            Bætavöruí();
        }

        private void bt_adalgluggi_Ís_Bland12stk_Click(object sender, EventArgs e)
        {
            voruheiti = "Ís Bland 12stk";
            Bætavöruí();
        }

        private void bt_adalgluggi_Toppar_Karamellu_Click(object sender, EventArgs e)
        {
            voruheiti = "Toppar Karamellu 6stk";
            Bætavöruí();
        }

        private void bt_adalgluggi_Toppar_Jarðaberja_Click(object sender, EventArgs e)
        {
            voruheiti = "Toppar Jarðaberja 6stk";
            Bætavöruí();
        }

        private void bt_adalgluggi_Frosinn_Kjulli_Click(object sender, EventArgs e)
        {
            voruheiti = "Frosinn kjúklingur Heill";
            Bætavöruí();
        }

        private void bt_adalgluggi_Frosið_Lamb_Click(object sender, EventArgs e)
        {
            voruheiti = "Frosið Lambakjöt 1/2 kg";
            Bætavöruí();
        }

        private void bt_adalgluggi_Frosið_Grisakjöt_Click(object sender, EventArgs e)
        {
            voruheiti = "Frosið Grísakjöt 1/2 kg";
            Bætavöruí();
        }

        private void bt_adalgluggi_numbpad_enter_Click(object sender, EventArgs e)
        {
            int voruheiti = Convert.ToInt32(rtb_adalgluggi_numpad.Text);
            string[] row = { "1",";", gagnagrunnur.Numbpad_heiti(voruheiti),";", gagnagrunnur.Numbpad_verd(voruheiti) };
            var listViewItem = new ListViewItem(row);
            Setja_I_Skra(row);
            list_adalgluggi_kerra.Items.Clear();
            Lesa_Ur_Skra();
            label_heildarverd_verd.Text = Convert.ToString(Heildarverð.Sum());


            rtb_adalgluggi_numpad.Clear();

            /*
            string[] row = { "1", ";", gagnagrunnur.GetVara(voruheiti), ";", gagnagrunnur.GetVaraVerd(voruheiti) };
            //samtals = samtals + Convert.ToInt32(row[4]);
            //label_heildarverd_verd.Text = samtals.ToString();
            var listViewItem = new ListViewItem(row);
            Setja_I_Skra(row);
            list_adalgluggi_kerra.Items.Clear();
            Lesa_Ur_Skra();
            label_heildarverd_verd.Text = Convert.ToString(Heildarverð.Sum());
            //label_heildarverd.Text += Convert.ToInt32(list_adalgluggi_kerra.Items[1].SubItems[1].Text);
             */
        }

        private void bt_adalgluggi_numbpad_0_Click(object sender, EventArgs e)
        {
            rtb_adalgluggi_numpad.Text += "0";
        }

        private void bt_adalgluggi_numbpad_delete_Click(object sender, EventArgs e)
        {
            rtb_adalgluggi_numpad.Clear();
        }

        private void bt_adalgluggi_voruleit_Click(object sender, EventArgs e)
        {
           
          Voruleit voruleit = new Voruleit();
          this.Close();
          voruleit.Show();

        }

        private void bt_adalgluggi_lokaKassa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }


        //textpad voids
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
        private void Lesa_Ur_Skra()
        {
            int nyastaverd = 0;
            string[] data;
            string line = null;
            try
            {
                StreamReader read = new StreamReader("karfa.txt");
                ListViewItem itm;
                Heildarverð.Clear();
                while ((line = read.ReadLine()) != null)
                {
                    data = line.Split(';');
                    nyastaverd = Convert.ToInt32(data[2]);
                    itm = new ListViewItem(data);
                    list_adalgluggi_kerra.Items.Add(itm);
                    //MessageBox.Show(Convert.ToString(Heildarverð.Sum())); sýnir heildarverð í textbox (fyrir testing)
                    Heildarverð.Add(nyastaverd);
                }
                read.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                throw;
            }
        }

        private void bt_adalgluggi_afslattur_Click(object sender, EventArgs e)
        {
            Afslattur afslattur = new Afslattur();
            afslattur.Show();
        }
        private void bt_adalgluggi_borga_Click(object sender, EventArgs e)
        {
            StreamWriter skrifari = File.CreateText("karfa.txt");
            skrifari.Close();
            list_adalgluggi_kerra.Items.Clear();
            Lesa_Ur_Skra();
        }
        public void Bætavöruí()
        {
            string[] row = { "1", ";", gagnagrunnur.GetVara(voruheiti), ";", gagnagrunnur.GetVaraVerd(voruheiti) };
            //samtals = samtals + Convert.ToInt32(row[4]);
            //label_heildarverd_verd.Text = samtals.ToString();
            var listViewItem = new ListViewItem(row);
            Setja_I_Skra(row);
            list_adalgluggi_kerra.Items.Clear();
            Lesa_Ur_Skra();
            label_heildarverd_verd.Text = Convert.ToString(Heildarverð.Sum());
            //label_heildarverd.Text += Convert.ToInt32(list_adalgluggi_kerra.Items[1].SubItems[1].Text);
            
        }

    }
}
