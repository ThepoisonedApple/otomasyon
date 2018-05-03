namespace login
{
    partial class TedarikciAdd
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
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.temail = new System.Windows.Forms.TextBox();
            this.tadres = new System.Windows.Forms.TextBox();
            this.ttel = new System.Windows.Forms.TextBox();
            this.tyadi = new System.Windows.Forms.TextBox();
            this.ttadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::login.Properties.Resources.Shutdown;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(0, 234);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 50);
            this.button11.TabIndex = 2;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::login.Properties.Resources.Home;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(0, 122);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::login.Properties.Resources.logo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(82, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 84);
            this.panel4.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(50, 575);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 25);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(156)))), ((int)(((byte)(236)))));
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 600);
            this.panel3.TabIndex = 12;
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::login.Properties.Resources.Info;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(0, 178);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 1;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(193)))), ((int)(((byte)(82)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(426, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 32;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // temail
            // 
            this.temail.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temail.ForeColor = System.Drawing.Color.Silver;
            this.temail.Location = new System.Drawing.Point(42, 309);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(247, 33);
            this.temail.TabIndex = 30;
            this.temail.Text = "e-mail";
            this.temail.Enter += new System.EventHandler(this.temail_Enter);
            // 
            // tadres
            // 
            this.tadres.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tadres.ForeColor = System.Drawing.Color.Silver;
            this.tadres.Location = new System.Drawing.Point(42, 148);
            this.tadres.Multiline = true;
            this.tadres.Name = "tadres";
            this.tadres.Size = new System.Drawing.Size(510, 94);
            this.tadres.TabIndex = 27;
            this.tadres.Text = "Firma Adresi";
            this.tadres.Enter += new System.EventHandler(this.temail_Enter);
            // 
            // ttel
            // 
            this.ttel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ttel.ForeColor = System.Drawing.Color.Silver;
            this.ttel.Location = new System.Drawing.Point(42, 259);
            this.ttel.MaxLength = 10;
            this.ttel.Name = "ttel";
            this.ttel.Size = new System.Drawing.Size(247, 33);
            this.ttel.TabIndex = 26;
            this.ttel.Text = "Telefon Numarası";
            this.ttel.Enter += new System.EventHandler(this.temail_Enter);
            // 
            // tyadi
            // 
            this.tyadi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tyadi.ForeColor = System.Drawing.Color.Silver;
            this.tyadi.Location = new System.Drawing.Point(42, 95);
            this.tyadi.Name = "tyadi";
            this.tyadi.Size = new System.Drawing.Size(358, 33);
            this.tyadi.TabIndex = 25;
            this.tyadi.Text = "Yetkili ad-soyad";
            this.tyadi.Enter += new System.EventHandler(this.temail_Enter);
            // 
            // ttadi
            // 
            this.ttadi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ttadi.ForeColor = System.Drawing.Color.Silver;
            this.ttadi.Location = new System.Drawing.Point(42, 46);
            this.ttadi.Name = "ttadi";
            this.ttadi.Size = new System.Drawing.Size(247, 33);
            this.ttadi.TabIndex = 24;
            this.ttadi.Text = "Tedarikçi firma ismi";
            this.ttadi.Enter += new System.EventHandler(this.temail_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(278, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tedarikçi Ekleme Paneli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(352, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "ModaVizyon";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.temail);
            this.panel5.Controls.Add(this.tadres);
            this.panel5.Controls.Add(this.ttel);
            this.panel5.Controls.Add(this.tyadi);
            this.panel5.Controls.Add(this.ttadi);
            this.panel5.Location = new System.Drawing.Point(82, 122);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(595, 435);
            this.panel5.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 600);
            this.panel1.TabIndex = 4;
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::login.Properties.Resources.Exit;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(675, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(25, 25);
            this.button12.TabIndex = 4;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // TedarikciAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TedarikciAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TedarikciAdd";
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox temail;
        private System.Windows.Forms.TextBox tadres;
        private System.Windows.Forms.TextBox ttel;
        private System.Windows.Forms.TextBox tyadi;
        private System.Windows.Forms.TextBox ttadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button12;
    }
}