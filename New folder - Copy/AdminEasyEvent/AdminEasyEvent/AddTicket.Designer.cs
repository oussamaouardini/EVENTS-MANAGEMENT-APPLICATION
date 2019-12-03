namespace AdminEasyEvent
{
    partial class AddTicket
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
            this.search = new JThinButton.JThinButton();
            this.name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.search.BorderRadius = 5;
            this.search.ButtonText = "Search";
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.search.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.search.ForeColors = System.Drawing.Color.White;
            this.search.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.search.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.search.HoverFontColor = System.Drawing.Color.White;
            this.search.LineThickness = 2;
            this.search.Location = new System.Drawing.Point(416, 16);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(125, 59);
            this.search.TabIndex = 37;
            // 
            // name
            // 
            this.name.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.name.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.name.BorderThickness = 1;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.name.isPassword = false;
            this.name.Location = new System.Drawing.Point(40, 16);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(350, 59);
            this.name.TabIndex = 36;
            this.name.Text = "Search";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.search);
            this.Controls.Add(this.name);
            this.Name = "AddTicket";
            this.Size = new System.Drawing.Size(1682, 850);
            this.Load += new System.EventHandler(this.AddTicket_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private JThinButton.JThinButton search;
        private Bunifu.Framework.UI.BunifuMetroTextbox name;
    }
}
