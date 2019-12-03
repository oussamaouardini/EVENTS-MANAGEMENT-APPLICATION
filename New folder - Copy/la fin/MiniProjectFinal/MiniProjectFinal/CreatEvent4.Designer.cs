namespace MiniProjectFinal
{
    partial class CreatEvent4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatEvent4));
            this.content = new System.Windows.Forms.Panel();
            this.back = new JThinButton.JThinButton();
            this.next = new JThinButton.JThinButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dess = new System.Windows.Forms.RichTextBox();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Controls.Add(this.dess);
            this.content.Controls.Add(this.back);
            this.content.Controls.Add(this.next);
            this.content.Controls.Add(this.label2);
            this.content.Controls.Add(this.label4);
            this.content.Controls.Add(this.button1);
            this.content.Controls.Add(this.label1);
            this.content.Controls.Add(this.label3);
            this.content.Location = new System.Drawing.Point(295, 49);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1040, 816);
            this.content.TabIndex = 0;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
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
            this.back.Location = new System.Drawing.Point(179, 632);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(125, 47);
            this.back.TabIndex = 30;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.next.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(53)))), ((int)(((byte)(52)))));
            this.next.BorderRadius = 0;
            this.next.ButtonText = "Submit";
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.next.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.next.ForeColors = System.Drawing.Color.White;
            this.next.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.next.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.next.HoverFontColor = System.Drawing.Color.White;
            this.next.LineThickness = 2;
            this.next.Location = new System.Drawing.Point(333, 632);
            this.next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(125, 47);
            this.next.TabIndex = 29;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ajoutez plus de détails à votre événement, comme votre calendrier, vos sponsors o" +
    "u vos invités.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Description ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(637, 173);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Il s\'agit de la première image que les participants verront en haut de votre list" +
    "e.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Image de l\'événement principal";
            // 
            // dess
            // 
            this.dess.BackColor = System.Drawing.Color.White;
            this.dess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dess.Location = new System.Drawing.Point(11, 357);
            this.dess.Name = "dess";
            this.dess.Size = new System.Drawing.Size(622, 206);
            this.dess.TabIndex = 34;
            this.dess.Text = "Ajoutez votre description ici:";
            this.dess.TextChanged += new System.EventHandler(this.dess_TextChanged);
            this.dess.Enter += new System.EventHandler(this.dessenter);
            this.dess.Leave += new System.EventHandler(this.dessleave);
            // 
            // CreatEvent4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.content);
            this.Name = "CreatEvent4";
            this.Size = new System.Drawing.Size(1682, 946);
            this.Load += new System.EventHandler(this.CreatEvent4_Load);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private JThinButton.JThinButton back;
        private JThinButton.JThinButton next;
        private System.Windows.Forms.RichTextBox dess;
    }
}
