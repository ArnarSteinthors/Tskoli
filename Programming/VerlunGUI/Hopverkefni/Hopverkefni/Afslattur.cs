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
    public partial class Afslattur : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public Afslattur()
        {            
            InitializeComponent();
            gagnagrunnur.TengingVidGagnagrunn();
        }

        private void Afslattur_Load(object sender, EventArgs e)
        {
            AdalGuggi adalgluggi = new AdalGuggi();
            adalgluggi.Hide();
        }       


        private void bt_afslattur_loka_glugga_Click(object sender, EventArgs e)
        {
            AdalGuggi adalgluggi = new AdalGuggi();
            adalgluggi.Show();
            this.Close();
        }        

        
    }
}
