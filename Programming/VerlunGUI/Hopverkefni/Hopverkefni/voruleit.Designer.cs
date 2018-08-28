namespace Hopverkefni
{
    partial class Voruleit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListView_voruleit_leitargluggi = new System.Windows.Forms.ListView();
            this.bt_voruleit_veljaVoru = new System.Windows.Forms.Button();
            this.tb_voruleit_leitardalkur = new System.Windows.Forms.TextBox();
            this.bt_voruleit_leita = new System.Windows.Forms.Button();
            this.bt_voruleit_LokaGlugga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView_voruleit_leitargluggi
            // 
            this.ListView_voruleit_leitargluggi.FullRowSelect = true;
            this.ListView_voruleit_leitargluggi.GridLines = true;
            this.ListView_voruleit_leitargluggi.Location = new System.Drawing.Point(12, 12);
            this.ListView_voruleit_leitargluggi.Name = "ListView_voruleit_leitargluggi";
            this.ListView_voruleit_leitargluggi.Size = new System.Drawing.Size(522, 443);
            this.ListView_voruleit_leitargluggi.TabIndex = 0;
            this.ListView_voruleit_leitargluggi.UseCompatibleStateImageBehavior = false;
            this.ListView_voruleit_leitargluggi.View = System.Windows.Forms.View.Details;
            this.ListView_voruleit_leitargluggi.SelectedIndexChanged += new System.EventHandler(this.ListView_voruleit_leitargluggi_SelectedIndexChanged);
            // 
            // bt_voruleit_veljaVoru
            // 
            this.bt_voruleit_veljaVoru.Location = new System.Drawing.Point(541, 307);
            this.bt_voruleit_veljaVoru.Name = "bt_voruleit_veljaVoru";
            this.bt_voruleit_veljaVoru.Size = new System.Drawing.Size(132, 84);
            this.bt_voruleit_veljaVoru.TabIndex = 1;
            this.bt_voruleit_veljaVoru.Text = "Velja Vöru";
            this.bt_voruleit_veljaVoru.UseVisualStyleBackColor = true;
            this.bt_voruleit_veljaVoru.Click += new System.EventHandler(this.bt_voruleit_veljaVoru_Click);
            // 
            // tb_voruleit_leitardalkur
            // 
            this.tb_voruleit_leitardalkur.Location = new System.Drawing.Point(12, 461);
            this.tb_voruleit_leitardalkur.Name = "tb_voruleit_leitardalkur";
            this.tb_voruleit_leitardalkur.Size = new System.Drawing.Size(444, 20);
            this.tb_voruleit_leitardalkur.TabIndex = 2;
            // 
            // bt_voruleit_leita
            // 
            this.bt_voruleit_leita.Location = new System.Drawing.Point(459, 461);
            this.bt_voruleit_leita.Name = "bt_voruleit_leita";
            this.bt_voruleit_leita.Size = new System.Drawing.Size(75, 20);
            this.bt_voruleit_leita.TabIndex = 3;
            this.bt_voruleit_leita.Text = "Leita";
            this.bt_voruleit_leita.UseVisualStyleBackColor = true;
            this.bt_voruleit_leita.Click += new System.EventHandler(this.bt_voruleit_leita_Click);
            // 
            // bt_voruleit_LokaGlugga
            // 
            this.bt_voruleit_LokaGlugga.Location = new System.Drawing.Point(540, 397);
            this.bt_voruleit_LokaGlugga.Name = "bt_voruleit_LokaGlugga";
            this.bt_voruleit_LokaGlugga.Size = new System.Drawing.Size(132, 84);
            this.bt_voruleit_LokaGlugga.TabIndex = 4;
            this.bt_voruleit_LokaGlugga.Text = "Loka";
            this.bt_voruleit_LokaGlugga.UseVisualStyleBackColor = true;
            this.bt_voruleit_LokaGlugga.Click += new System.EventHandler(this.bt_voruleit_LokaGlugga_Click);
            // 
            // Voruleit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 493);
            this.Controls.Add(this.bt_voruleit_LokaGlugga);
            this.Controls.Add(this.bt_voruleit_leita);
            this.Controls.Add(this.tb_voruleit_leitardalkur);
            this.Controls.Add(this.bt_voruleit_veljaVoru);
            this.Controls.Add(this.ListView_voruleit_leitargluggi);
            this.Name = "Voruleit";
            this.Text = "voruleit";
            this.Load += new System.EventHandler(this.Voruleit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView_voruleit_leitargluggi;
        private System.Windows.Forms.Button bt_voruleit_veljaVoru;
        private System.Windows.Forms.TextBox tb_voruleit_leitardalkur;
        private System.Windows.Forms.Button bt_voruleit_leita;
        private System.Windows.Forms.Button bt_voruleit_LokaGlugga;
    }
}