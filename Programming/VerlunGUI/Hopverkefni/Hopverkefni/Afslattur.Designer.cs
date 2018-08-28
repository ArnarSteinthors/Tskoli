namespace Hopverkefni
{
    partial class Afslattur
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
            this.bt_afslattur = new System.Windows.Forms.Button();
            this.tb_afslattur_tala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_afslattur_loka_glugga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_afslattur
            // 
            this.bt_afslattur.Location = new System.Drawing.Point(30, 59);
            this.bt_afslattur.Name = "bt_afslattur";
            this.bt_afslattur.Size = new System.Drawing.Size(129, 63);
            this.bt_afslattur.TabIndex = 1;
            this.bt_afslattur.Text = "Staðfesta";
            this.bt_afslattur.UseVisualStyleBackColor = true;
            // 
            // tb_afslattur_tala
            // 
            this.tb_afslattur_tala.Location = new System.Drawing.Point(69, 33);
            this.tb_afslattur_tala.Name = "tb_afslattur_tala";
            this.tb_afslattur_tala.Size = new System.Drawing.Size(48, 20);
            this.tb_afslattur_tala.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "%";
            // 
            // bt_afslattur_loka_glugga
            // 
            this.bt_afslattur_loka_glugga.Location = new System.Drawing.Point(30, 128);
            this.bt_afslattur_loka_glugga.Name = "bt_afslattur_loka_glugga";
            this.bt_afslattur_loka_glugga.Size = new System.Drawing.Size(129, 35);
            this.bt_afslattur_loka_glugga.TabIndex = 4;
            this.bt_afslattur_loka_glugga.Text = "Loka Glugga";
            this.bt_afslattur_loka_glugga.UseVisualStyleBackColor = true;
            this.bt_afslattur_loka_glugga.Click += new System.EventHandler(this.bt_afslattur_loka_glugga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Afsláttur";
            // 
            // Afslattur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 191);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_afslattur_loka_glugga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_afslattur_tala);
            this.Controls.Add(this.bt_afslattur);
            this.Name = "Afslattur";
            this.Text = "Afsláttur";
            this.Load += new System.EventHandler(this.Afslattur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_afslattur;
        private System.Windows.Forms.TextBox tb_afslattur_tala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_afslattur_loka_glugga;
        private System.Windows.Forms.Label label2;
    }
}