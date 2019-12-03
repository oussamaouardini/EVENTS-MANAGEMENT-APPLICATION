namespace MiniProjectFinal
{
    partial class Tickets
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
            this.register1 = new MiniProjectFinal.register();
            this.SuspendLayout();
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.White;
            this.register1.Location = new System.Drawing.Point(-6, 2);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(804, 639);
            this.register1.TabIndex = 0;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 647);
            this.Controls.Add(this.register1);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.ResumeLayout(false);

        }

        #endregion

        private register register1;
    }
}