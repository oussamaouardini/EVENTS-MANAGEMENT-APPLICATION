namespace MiniProjectFinal
{
    partial class CreateEvent5
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.back = new JThinButton.JThinButton();
            this.next = new JThinButton.JThinButton();
            this.state = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.city = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.White;
            this.content.Controls.Add(this.label4);
            this.content.Controls.Add(this.label2);
            this.content.Controls.Add(this.bunifuDropdown1);
            this.content.Controls.Add(this.back);
            this.content.Controls.Add(this.next);
            this.content.Controls.Add(this.state);
            this.content.Controls.Add(this.city);
            this.content.Controls.Add(this.label1);
            this.content.Controls.Add(this.bunifuProgressBar1);
            this.content.Controls.Add(this.label3);
            this.content.Location = new System.Drawing.Point(295, 48);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1040, 816);
            this.content.TabIndex = 3;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Prix de billet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "nombre de billets disponibles";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.Items = new string[] {
        "public",
        "privé"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(12, 150);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.White;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.White;
            this.bunifuDropdown1.selectedIndex = 0;
            this.bunifuDropdown1.Size = new System.Drawing.Size(634, 59);
            this.bunifuDropdown1.TabIndex = 32;
            this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundColor = System.Drawing.Color.White;
            this.back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.back.BorderRadius = 0;
            this.back.ButtonText = "Retour";
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.back.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.back.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.back.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.back.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.back.HoverFontColor = System.Drawing.Color.White;
            this.back.LineThickness = 2;
            this.back.Location = new System.Drawing.Point(111, 348);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(125, 47);
            this.back.TabIndex = 31;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.next.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.next.BorderRadius = 0;
            this.next.ButtonText = "Suivant";
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.next.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.next.ForeColors = System.Drawing.Color.White;
            this.next.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.next.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.next.HoverFontColor = System.Drawing.Color.White;
            this.next.LineThickness = 2;
            this.next.Location = new System.Drawing.Point(293, 348);
            this.next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(125, 47);
            this.next.TabIndex = 30;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // state
            // 
            this.state.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.state.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.state.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.state.BorderThickness = 1;
            this.state.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.state.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.state.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.state.isPassword = false;
            this.state.Location = new System.Drawing.Point(393, 237);
            this.state.Margin = new System.Windows.Forms.Padding(4);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(253, 59);
            this.state.TabIndex = 28;
            this.state.Text = "Prix de billet";
            this.state.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // city
            // 
            this.city.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.city.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.city.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.city.BorderThickness = 1;
            this.city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.city.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.city.isPassword = false;
            this.city.Location = new System.Drawing.Point(9, 237);
            this.city.Margin = new System.Windows.Forms.Padding(4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(323, 59);
            this.city.TabIndex = 27;
            this.city.Text = "nombre de billets disponibles";
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Étape 4 sur 4";
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(12, 50);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(140)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(750, 5);
            this.bunifuProgressBar1.TabIndex = 22;
            this.bunifuProgressBar1.Value = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cet événement est ?";
            // 
            // CreateEvent5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.content);
            this.Name = "CreateEvent5";
            this.Size = new System.Drawing.Size(1682, 946);
            this.Load += new System.EventHandler(this.CreateEvent5_Load);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private JThinButton.JThinButton back;
        private JThinButton.JThinButton next;
        private Bunifu.Framework.UI.BunifuMetroTextbox state;
        private Bunifu.Framework.UI.BunifuMetroTextbox city;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Label label3;
    }
}
