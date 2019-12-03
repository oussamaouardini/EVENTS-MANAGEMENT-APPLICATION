namespace MiniProjectFinal
{
    partial class CreatEvent
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
            this.content = new System.Windows.Forms.Panel();
            this.Cancel = new JThinButton.JThinButton();
            this.next = new JThinButton.JThinButton();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Controls.Add(this.Cancel);
            this.content.Controls.Add(this.next);
            this.content.Controls.Add(this.bunifuDropdown1);
            this.content.Controls.Add(this.bunifuProgressBar1);
            this.content.Controls.Add(this.label2);
            this.content.Controls.Add(this.label3);
            this.content.Controls.Add(this.label1);
            this.content.Location = new System.Drawing.Point(294, 51);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1040, 816);
            this.content.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.BackgroundColor = System.Drawing.Color.White;
            this.Cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Cancel.BorderRadius = 0;
            this.Cancel.ButtonText = "Cancel";
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Cancel.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Cancel.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Cancel.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Cancel.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.Cancel.HoverFontColor = System.Drawing.Color.White;
            this.Cancel.LineThickness = 2;
            this.Cancel.Location = new System.Drawing.Point(280, 442);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(125, 47);
            this.Cancel.TabIndex = 11;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.next.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.next.BorderRadius = 0;
            this.next.ButtonText = "  Next";
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.next.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.next.ForeColors = System.Drawing.Color.White;
            this.next.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.next.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.next.HoverFontColor = System.Drawing.Color.White;
            this.next.LineThickness = 2;
            this.next.Location = new System.Drawing.Point(434, 442);
            this.next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(125, 47);
            this.next.TabIndex = 10;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.Items = new string[] {
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
        "Réunions"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(14, 315);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.White;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.White;
            this.bunifuDropdown1.selectedIndex = 1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(750, 59);
            this.bunifuDropdown1.TabIndex = 9;
            this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(14, 198);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(140)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(750, 5);
            this.bunifuProgressBar1.TabIndex = 8;
            this.bunifuProgressBar1.Value = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(11, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Step 1 out of 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "What type of event you want to create ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "We’ll ask you a few questions to start\r\nbuilding your event.";
            // 
            // CreatEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.content);
            this.Name = "CreatEvent";
            this.Size = new System.Drawing.Size(1682, 946);
            this.Load += new System.EventHandler(this.CreatEvent_Load);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private JThinButton.JThinButton Cancel;
        private JThinButton.JThinButton next;
    }
}
