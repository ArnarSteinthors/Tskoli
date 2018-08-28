namespace Hopverkefni
{
    partial class Form1
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
            this.list_login = new System.Windows.Forms.ListView();
            this.bt_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_form1_LokaApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_login
            // 
            this.list_login.FullRowSelect = true;
            this.list_login.GridLines = true;
            this.list_login.HideSelection = false;
            this.list_login.Location = new System.Drawing.Point(12, 27);
            this.list_login.Name = "list_login";
            this.list_login.Size = new System.Drawing.Size(266, 345);
            this.list_login.TabIndex = 2;
            this.list_login.UseCompatibleStateImageBehavior = false;
            this.list_login.View = System.Windows.Forms.View.Details;
            this.list_login.SelectedIndexChanged += new System.EventHandler(this.list_login_SelectedIndexChanged_1);
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(354, 141);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(119, 65);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Staðfesta";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lykilorð";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Notendanafn";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.ForeColor = System.Drawing.Color.Red;
            this.label_login.Location = new System.Drawing.Point(375, 127);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(0, 13);
            this.label_login.TabIndex = 7;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(354, 104);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(119, 20);
            this.tb_password.TabIndex = 8;
            // 
            // bt_form1_LokaApp
            // 
            this.bt_form1_LokaApp.Location = new System.Drawing.Point(354, 307);
            this.bt_form1_LokaApp.Name = "bt_form1_LokaApp";
            this.bt_form1_LokaApp.Size = new System.Drawing.Size(119, 65);
            this.bt_form1_LokaApp.TabIndex = 9;
            this.bt_form1_LokaApp.Text = "Loka Forriti";
            this.bt_form1_LokaApp.UseVisualStyleBackColor = true;
            this.bt_form1_LokaApp.Click += new System.EventHandler(this.bt_form1_LokaApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 384);
            this.Controls.Add(this.bt_form1_LokaApp);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.list_login);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_login;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_form1_LokaApp;
    }
}

