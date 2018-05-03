namespace login
{
    partial class ASiparisAdd
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
            this.button12 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.thid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tadet = new System.Windows.Forms.TextBox();
            this.tfiyat = new System.Windows.Forms.TextBox();
            this.tbtarih = new System.Windows.Forms.TextBox();
            this.tstarih = new System.Windows.Forms.TextBox();
            this.ttid = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(700, 505);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(278, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sipariş Ekleme Paneli";
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
            this.panel5.Controls.Add(this.thid);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.tadet);
            this.panel5.Controls.Add(this.tfiyat);
            this.panel5.Controls.Add(this.tbtarih);
            this.panel5.Controls.Add(this.tstarih);
            this.panel5.Controls.Add(this.ttid);
            this.panel5.Location = new System.Drawing.Point(82, 122);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(593, 342);
            this.panel5.TabIndex = 24;
            // 
            // thid
            // 
            this.thid.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.thid.ForeColor = System.Drawing.Color.Silver;
            this.thid.Location = new System.Drawing.Point(319, 46);
            this.thid.MaxLength = 10;
            this.thid.Name = "thid";
            this.thid.Size = new System.Drawing.Size(233, 33);
            this.thid.TabIndex = 33;
            this.thid.Text = "hammadde ID";
            this.thid.Enter += new System.EventHandler(this.ttid_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(193)))), ((int)(((byte)(82)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(426, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 32;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tadet
            // 
            this.tadet.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tadet.ForeColor = System.Drawing.Color.Silver;
            this.tadet.Location = new System.Drawing.Point(42, 179);
            this.tadet.Name = "tadet";
            this.tadet.Size = new System.Drawing.Size(233, 33);
            this.tadet.TabIndex = 30;
            this.tadet.Text = "adet";
            this.tadet.Enter += new System.EventHandler(this.ttid_Enter);
            // 
            // tfiyat
            // 
            this.tfiyat.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tfiyat.ForeColor = System.Drawing.Color.Silver;
            this.tfiyat.Location = new System.Drawing.Point(42, 241);
            this.tfiyat.Name = "tfiyat";
            this.tfiyat.Size = new System.Drawing.Size(233, 33);
            this.tfiyat.TabIndex = 28;
            this.tfiyat.Text = "fiyat";
            this.tfiyat.Enter += new System.EventHandler(this.ttid_Enter);
            // 
            // tbtarih
            // 
            this.tbtarih.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbtarih.ForeColor = System.Drawing.Color.Silver;
            this.tbtarih.Location = new System.Drawing.Point(319, 112);
            this.tbtarih.MaxLength = 10;
            this.tbtarih.Name = "tbtarih";
            this.tbtarih.Size = new System.Drawing.Size(233, 33);
            this.tbtarih.TabIndex = 26;
            this.tbtarih.Text = "beklenen tarih";
            this.tbtarih.Enter += new System.EventHandler(this.ttid_Enter);
            // 
            // tstarih
            // 
            this.tstarih.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tstarih.ForeColor = System.Drawing.Color.Black;
            this.tstarih.Location = new System.Drawing.Point(42, 112);
            this.tstarih.Name = "tstarih";
            this.tstarih.Size = new System.Drawing.Size(233, 33);
            this.tstarih.TabIndex = 25;
            this.tstarih.Text = "Sipariş tarihi";
            this.tstarih.Enter += new System.EventHandler(this.ttid_Enter);
            // 
            // ttid
            // 
            this.ttid.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ttid.ForeColor = System.Drawing.Color.Silver;
            this.ttid.Location = new System.Drawing.Point(42, 46);
            this.ttid.Name = "ttid";
            this.ttid.Size = new System.Drawing.Size(233, 33);
            this.ttid.TabIndex = 24;
            this.ttid.Text = "Tedarikçi ID";
            this.ttid.Enter += new System.EventHandler(this.ttid_Enter);
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
            this.panel2.Location = new System.Drawing.Point(49, 480);
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
            this.panel3.Size = new System.Drawing.Size(50, 505);
            this.panel3.TabIndex = 12;
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
            // ASiparisAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 505);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ASiparisAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASiparisAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox thid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tadet;
        private System.Windows.Forms.TextBox tfiyat;
        private System.Windows.Forms.TextBox tbtarih;
        private System.Windows.Forms.TextBox tstarih;
        private System.Windows.Forms.TextBox ttid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
    }
}