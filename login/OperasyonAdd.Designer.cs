namespace login
{
    partial class OperasyonAdd
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
            this.badd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toadi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totanim = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bexit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.blogout = new System.Windows.Forms.Button();
            this.binfo = new System.Windows.Forms.Button();
            this.bhome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(193)))), ((int)(((byte)(82)))));
            this.badd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.badd.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.badd.ForeColor = System.Drawing.Color.White;
            this.badd.Location = new System.Drawing.Point(406, 224);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(126, 54);
            this.badd.TabIndex = 32;
            this.badd.Text = "Ekle";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(339, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "ModaVizyon";
            // 
            // toadi
            // 
            this.toadi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toadi.ForeColor = System.Drawing.Color.Silver;
            this.toadi.Location = new System.Drawing.Point(22, 33);
            this.toadi.Name = "toadi";
            this.toadi.Size = new System.Drawing.Size(233, 33);
            this.toadi.TabIndex = 24;
            this.toadi.Text = "Operasyon Adı";
            this.toadi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.bexit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 466);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(254, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Operasyon Ekleme Paneli";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.Controls.Add(this.totanim);
            this.panel5.Controls.Add(this.badd);
            this.panel5.Controls.Add(this.toadi);
            this.panel5.Location = new System.Drawing.Point(82, 122);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(573, 304);
            this.panel5.TabIndex = 24;
            // 
            // totanim
            // 
            this.totanim.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totanim.ForeColor = System.Drawing.Color.Silver;
            this.totanim.Location = new System.Drawing.Point(22, 91);
            this.totanim.Multiline = true;
            this.totanim.Name = "totanim";
            this.totanim.Size = new System.Drawing.Size(510, 108);
            this.totanim.TabIndex = 34;
            this.totanim.Text = "Operasyon Tanımı";
            this.totanim.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(50, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 25);
            this.panel2.TabIndex = 13;
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
            // bexit
            // 
            this.bexit.BackgroundImage = global::login.Properties.Resources.Exit;
            this.bexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bexit.Location = new System.Drawing.Point(663, 0);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(25, 25);
            this.bexit.TabIndex = 4;
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(156)))), ((int)(((byte)(236)))));
            this.panel3.Controls.Add(this.blogout);
            this.panel3.Controls.Add(this.binfo);
            this.panel3.Controls.Add(this.bhome);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 466);
            this.panel3.TabIndex = 12;
            // 
            // blogout
            // 
            this.blogout.BackgroundImage = global::login.Properties.Resources.Shutdown;
            this.blogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blogout.Location = new System.Drawing.Point(0, 251);
            this.blogout.Name = "blogout";
            this.blogout.Size = new System.Drawing.Size(50, 50);
            this.blogout.TabIndex = 2;
            this.blogout.UseVisualStyleBackColor = true;
            this.blogout.Click += new System.EventHandler(this.blogout_Click);
            // 
            // binfo
            // 
            this.binfo.BackgroundImage = global::login.Properties.Resources.Info;
            this.binfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.binfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binfo.Location = new System.Drawing.Point(0, 195);
            this.binfo.Name = "binfo";
            this.binfo.Size = new System.Drawing.Size(50, 50);
            this.binfo.TabIndex = 1;
            this.binfo.UseVisualStyleBackColor = true;
            this.binfo.Click += new System.EventHandler(this.binfo_Click);
            // 
            // bhome
            // 
            this.bhome.BackgroundImage = global::login.Properties.Resources.Home;
            this.bhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bhome.Location = new System.Drawing.Point(0, 139);
            this.bhome.Name = "bhome";
            this.bhome.Size = new System.Drawing.Size(50, 50);
            this.bhome.TabIndex = 0;
            this.bhome.UseVisualStyleBackColor = false;
            this.bhome.Click += new System.EventHandler(this.bhome_Click);
            // 
            // OperasyonAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 466);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OperasyonAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperasyonAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button binfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button blogout;
        private System.Windows.Forms.TextBox toadi;
        private System.Windows.Forms.Button bhome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox totanim;
    }
}