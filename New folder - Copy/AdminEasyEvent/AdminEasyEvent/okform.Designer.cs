namespace AdminEasyEvent
{
    partial class okform
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
            this.label1 = new System.Windows.Forms.Label();
            this.jThinButton1 = new JThinButton.JThinButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // jThinButton1
            // 
            this.jThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.jThinButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.jThinButton1.BorderRadius = 5;
            this.jThinButton1.ButtonText = "       ok";
            this.jThinButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.jThinButton1.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.jThinButton1.ForeColors = System.Drawing.Color.White;
            this.jThinButton1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.jThinButton1.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.jThinButton1.HoverFontColor = System.Drawing.Color.White;
            this.jThinButton1.LineThickness = 2;
            this.jThinButton1.Location = new System.Drawing.Point(215, 203);
            this.jThinButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jThinButton1.Name = "jThinButton1";
            this.jThinButton1.Size = new System.Drawing.Size(125, 59);
            this.jThinButton1.TabIndex = 35;
            this.jThinButton1.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // okform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(613, 303);
            this.Controls.Add(this.jThinButton1);
            this.Controls.Add(this.label1);
            this.Name = "okform";
            this.Text = "okform";
            this.Load += new System.EventHandler(this.okform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private JThinButton.JThinButton jThinButton1;
    }
}