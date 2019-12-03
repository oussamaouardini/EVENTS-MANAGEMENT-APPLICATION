using System;

namespace MiniProjectFinal
{
    partial class TicketRe
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
            this.registre1 = new MiniProjectFinal.Registre();
           
           // this.registre1 = new MiniProjectFinal.Registre(n,l,a,b,c,d,e,f);
            this.SuspendLayout();
            // 
            // registre1
            // 
            this.registre1.BackColor = System.Drawing.Color.White;
            this.registre1.Location = new System.Drawing.Point(-5, 0);
            this.registre1.Name = "registre1";
            this.registre1.Size = new System.Drawing.Size(804, 639);
            this.registre1.TabIndex = 0;
            this.registre1.Load += new System.EventHandler(this.registre1_Load);
            // 
            // TicketRe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 640);
            this.Controls.Add(this.registre1);
            this.Name = "TicketRe";
            this.Text = "TicketRe";
            this.ResumeLayout(false);

        }

        private void InitializeComponent(String name, String imgloc, String Ev_loc, String dtb, String orga, String add, String price, String dtf,String m , String p)
        {
            //this.registre1 = new MiniProjectFinal.Registre();

             this.registre1 = new MiniProjectFinal.Registre(name, imgloc, Ev_loc, dtb, orga, add, price, dtf,m,p);
            this.SuspendLayout();
            // 
            // registre1
            // 
            this.registre1.BackColor = System.Drawing.Color.White;
            this.registre1.Location = new System.Drawing.Point(-5, 0);
            this.registre1.Name = "registre1";
            this.registre1.Size = new System.Drawing.Size(804, 639);
            this.registre1.TabIndex = 0;
            this.registre1.Load += new System.EventHandler(this.registre1_Load);
            // 
            // TicketRe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 640);
            this.Controls.Add(this.registre1);
            this.Name = "TicketRe";
            this.Text = "TicketRe";
            this.ResumeLayout(false);

        }

        #endregion

        private Registre registre1;
    }
}