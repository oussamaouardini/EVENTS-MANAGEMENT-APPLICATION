namespace MiniProjectFinal
{
    partial class CreditCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardType = new System.Windows.Forms.PictureBox();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdown2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.jThinButton1 = new JThinButton.JThinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox5 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label22 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.cardType);
            this.panel1.Controls.Add(this.bunifuDropdown1);
            this.panel1.Controls.Add(this.bunifuDropdown2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.jThinButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuMetroTextbox5);
            this.panel1.Controls.Add(this.bunifuMetroTextbox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 639);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(416, 216);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // cardType
            // 
            this.cardType.Location = new System.Drawing.Point(402, 304);
            this.cardType.Name = "cardType";
            this.cardType.Size = new System.Drawing.Size(40, 40);
            this.cardType.TabIndex = 1;
            this.cardType.TabStop = false;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuDropdown1.Items = new string[] {
        "     Janvier",
        "     Févriere",
        "     Mars",
        "     Avril",
        "     Mai",
        "     Juin",
        "     Juillet",
        "     Aout",
        "     Septembre",
        "     Octobre",
        "     Novembre",
        "     Décembre"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(33, 379);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.White;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.White;
            this.bunifuDropdown1.selectedIndex = 0;
            this.bunifuDropdown1.Size = new System.Drawing.Size(248, 49);
            this.bunifuDropdown1.TabIndex = 1;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.White;
            this.bunifuDropdown2.BorderRadius = 3;
            this.bunifuDropdown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDropdown2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold);
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuDropdown2.Items = new string[] {
        "     2019",
        "     2020",
        "     2021",
        "     2022",
        "     2023",
        "     2024",
        "     2025",
        "     "};
            this.bunifuDropdown2.Location = new System.Drawing.Point(289, 380);
            this.bunifuDropdown2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.NomalColor = System.Drawing.Color.White;
            this.bunifuDropdown2.onHoverColor = System.Drawing.Color.White;
            this.bunifuDropdown2.selectedIndex = 0;
            this.bunifuDropdown2.Size = new System.Drawing.Size(160, 49);
            this.bunifuDropdown2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "CVC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Expiration Date";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(31, 279);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(127, 16);
            this.label26.TabIndex = 7;
            this.label26.Text = "Credit card number";
            // 
            // jThinButton1
            // 
            this.jThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(82)))), ((int)(((byte)(234)))));
            this.jThinButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(82)))), ((int)(((byte)(234)))));
            this.jThinButton1.BorderRadius = 5;
            this.jThinButton1.ButtonText = "Make payment";
            this.jThinButton1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton1.Font_Size = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton1.ForeColors = System.Drawing.Color.White;
            this.jThinButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(82)))), ((int)(((byte)(234)))));
            this.jThinButton1.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(82)))), ((int)(((byte)(234)))));
            this.jThinButton1.HoverFontColor = System.Drawing.Color.White;
            this.jThinButton1.LineThickness = 2;
            this.jThinButton1.Location = new System.Drawing.Point(34, 541);
            this.jThinButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.jThinButton1.Name = "jThinButton1";
            this.jThinButton1.Size = new System.Drawing.Size(416, 63);
            this.jThinButton1.TabIndex = 6;
            this.jThinButton1.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment details ";
            // 
            // bunifuMetroTextbox5
            // 
            this.bunifuMetroTextbox5.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox5.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox5.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox5.BorderThickness = 1;
            this.bunifuMetroTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox5.isPassword = false;
            this.bunifuMetroTextbox5.Location = new System.Drawing.Point(33, 463);
            this.bunifuMetroTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox5.Name = "bunifuMetroTextbox5";
            this.bunifuMetroTextbox5.Size = new System.Drawing.Size(160, 49);
            this.bunifuMetroTextbox5.TabIndex = 5;
            this.bunifuMetroTextbox5.Text = "123";
            this.bunifuMetroTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMetroTextbox5_KeyPress);
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 1;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(33, 299);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(416, 49);
            this.bunifuMetroTextbox1.TabIndex = 1;
            this.bunifuMetroTextbox1.Text = "1234 5678 9876 5432";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label22.Location = new System.Drawing.Point(528, 360);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(247, 2);
            this.label22.TabIndex = 16;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label28.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label28.Location = new System.Drawing.Point(29, 279);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(51, 22);
            this.label28.TabIndex = 5;
            this.label28.Text = "Total";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label29.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label29.Location = new System.Drawing.Point(204, 279);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(76, 22);
            this.label29.TabIndex = 9;
            this.label29.Text = "$200.00";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label4.Location = new System.Drawing.Point(528, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 2);
            this.label4.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label5.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label5.Location = new System.Drawing.Point(630, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cancel payment";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(495, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 639);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // CreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CreditCard";
            this.Size = new System.Drawing.Size(804, 639);
            this.Load += new System.EventHandler(this.CreditCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox5;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private JThinButton.JThinButton jThinButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox cardType;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}
