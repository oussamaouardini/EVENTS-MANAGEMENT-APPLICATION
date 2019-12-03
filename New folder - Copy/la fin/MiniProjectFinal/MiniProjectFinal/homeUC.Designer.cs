namespace MiniProjectFinal
{
    partial class homeUC
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.locatLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuDropdown3 = new Bunifu.Framework.UI.BunifuDropdown();
            this.jThinButton3 = new JThinButton.JThinButton();
            this.type = new Bunifu.Framework.UI.BunifuDropdown();
            this.startDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "à";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1008, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type événement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Je veux aller";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Populaire dans";
            // 
            // locatLabel
            // 
            this.locatLabel.AutoSize = true;
            this.locatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.locatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.locatLabel.Location = new System.Drawing.Point(211, 252);
            this.locatLabel.Name = "locatLabel";
            this.locatLabel.Size = new System.Drawing.Size(180, 22);
            this.locatLabel.TabIndex = 4;
            this.locatLabel.Text = "Sous-Massa-Daraa";
            this.locatLabel.Click += new System.EventHandler(this.locatLabel_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(110, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 2);
            this.label5.TabIndex = 5;
            // 
            // bunifuDropdown3
            // 
            this.bunifuDropdown3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown3.BorderRadius = 3;
            this.bunifuDropdown3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDropdown3.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown3.Items = new string[] {
        "Chaouia-Ouardigha ",
        "Doukkala-Abda ",
        "Fès-Boulemane ",
        "Gharb-Chrarda-Beni Hssen ",
        "Grand Casablanca ",
        "Guelmim-Es Semara ",
        "Laâyoune-Boujdour-Sakia el Hamra ",
        "Marrakech-Tensift-Al Haouz ",
        "Meknès-Tafilalet ",
        "L\'Oriental ",
        "Oued ed Dahab-Lagouira ",
        "Rabat-Salé-Zemmour-Zaër ",
        "Souss-Massa-Drâa ",
        "Tadla-Azilal ",
        "Tanger-Tétouan ",
        "Wilaya de Tanger",
        "Wilaya de Tétouan",
        "Taza-Al Hoceïma-Taounate "};
            this.bunifuDropdown3.Location = new System.Drawing.Point(623, 129);
            this.bunifuDropdown3.Name = "bunifuDropdown3";
            this.bunifuDropdown3.NomalColor = System.Drawing.Color.White;
            this.bunifuDropdown3.onHoverColor = System.Drawing.Color.White;
            this.bunifuDropdown3.selectedIndex = 12;
            this.bunifuDropdown3.Size = new System.Drawing.Size(298, 35);
            this.bunifuDropdown3.TabIndex = 7;
            this.bunifuDropdown3.onItemSelected += new System.EventHandler(this.bunifuDropdown3_onItemSelected);
            // 
            // jThinButton3
            // 
            this.jThinButton3.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(163)))), ((int)(((byte)(64)))));
            this.jThinButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(163)))), ((int)(((byte)(64)))));
            this.jThinButton3.BorderRadius = 18;
            this.jThinButton3.ButtonText = "Chercher";
            this.jThinButton3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.jThinButton3.Font_Size = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.jThinButton3.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(115)))));
            this.jThinButton3.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(163)))), ((int)(((byte)(64)))));
            this.jThinButton3.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(163)))), ((int)(((byte)(64)))));
            this.jThinButton3.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(115)))));
            this.jThinButton3.LineThickness = 2;
            this.jThinButton3.Location = new System.Drawing.Point(681, 198);
            this.jThinButton3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.jThinButton3.Name = "jThinButton3";
            this.jThinButton3.Size = new System.Drawing.Size(190, 44);
            this.jThinButton3.TabIndex = 10;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.BorderRadius = 3;
            this.type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.type.ForeColor = System.Drawing.Color.Black;
            this.type.Items = new string[] {
        "Assemblées d\'actionnaires",
        "Lancements de produits",
        "Anniversaires de mariage",
        "Conférences de presse",
        "Conférences de sports",
        "Événements familiaux",
        "Dîners d\'affaires",
        "Anniversaires",
        "Conférences",
        "Séminaires",
        "Soirées",
        "Réunions",
        "Music"};
            this.type.Location = new System.Drawing.Point(1012, 129);
            this.type.Name = "type";
            this.type.NomalColor = System.Drawing.Color.White;
            this.type.onHoverColor = System.Drawing.Color.White;
            this.type.selectedIndex = 3;
            this.type.Size = new System.Drawing.Size(298, 35);
            this.type.TabIndex = 12;
            this.type.onItemSelected += new System.EventHandler(this.bunifuDropdown2_onItemSelected);
            // 
            // startDate
            // 
            this.startDate.BackColor = System.Drawing.Color.White;
            this.startDate.BorderRadius = 0;
            this.startDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.ForeColor = System.Drawing.Color.Black;
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startDate.FormatCustom = null;
            this.startDate.Location = new System.Drawing.Point(231, 129);
            this.startDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(298, 35);
            this.startDate.TabIndex = 33;
            this.startDate.Tag = "";
            this.startDate.Value = new System.DateTime(2019, 11, 22, 21, 46, 26, 778);
            this.startDate.onValueChanged += new System.EventHandler(this.startDate_onValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 35;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // homeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.type);
            this.Controls.Add(this.jThinButton3);
            this.Controls.Add(this.bunifuDropdown3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.locatLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "homeUC";
            this.Size = new System.Drawing.Size(1682, 946);
            this.Load += new System.EventHandler(this.homeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.Label label3;
        
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label locatLabel;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown3;
        private JThinButton.JThinButton jThinButton3;
        private Bunifu.Framework.UI.BunifuDropdown type;
        private Bunifu.Framework.UI.BunifuDatepicker startDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}
