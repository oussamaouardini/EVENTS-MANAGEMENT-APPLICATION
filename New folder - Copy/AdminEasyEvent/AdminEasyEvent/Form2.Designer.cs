namespace AdminEasyEvent
{
    partial class msgbx
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new JThinButton.JThinButton();
            this.jThinButton1 = new JThinButton.JThinButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 34);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.search.BorderRadius = 5;
            this.search.ButtonText = "Anuuler";
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.search.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.search.ForeColors = System.Drawing.Color.White;
            this.search.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.search.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.search.HoverFontColor = System.Drawing.Color.White;
            this.search.LineThickness = 2;
            this.search.Location = new System.Drawing.Point(90, 176);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(125, 59);
            this.search.TabIndex = 33;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // jThinButton1
            // 
            this.jThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.jThinButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.jThinButton1.BorderRadius = 5;
            this.jThinButton1.ButtonText = "Supprimer";
            this.jThinButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.jThinButton1.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.jThinButton1.ForeColors = System.Drawing.Color.White;
            this.jThinButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.jThinButton1.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.jThinButton1.HoverFontColor = System.Drawing.Color.White;
            this.jThinButton1.LineThickness = 2;
            this.jThinButton1.Location = new System.Drawing.Point(344, 176);
            this.jThinButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jThinButton1.Name = "jThinButton1";
            this.jThinButton1.Size = new System.Drawing.Size(125, 59);
            this.jThinButton1.TabIndex = 34;
            this.jThinButton1.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // msgbx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 299);
            this.Controls.Add(this.jThinButton1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "msgbx";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.msgbx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private JThinButton.JThinButton search;
        private JThinButton.JThinButton jThinButton1;
    }
}