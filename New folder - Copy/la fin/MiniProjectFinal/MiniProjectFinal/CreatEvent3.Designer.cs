namespace MiniProjectFinal
{
    partial class CreatEvent3
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
            this.label7 = new System.Windows.Forms.Label();
            this.endTime = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.startTime = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.startDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.state = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.city = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new JThinButton.JThinButton();
            this.next = new JThinButton.JThinButton();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Controls.Add(this.label7);
            this.content.Controls.Add(this.endTime);
            this.content.Controls.Add(this.label6);
            this.content.Controls.Add(this.startTime);
            this.content.Controls.Add(this.bunifuDatepicker1);
            this.content.Controls.Add(this.label5);
            this.content.Controls.Add(this.startDate);
            this.content.Controls.Add(this.label4);
            this.content.Controls.Add(this.label2);
            this.content.Controls.Add(this.zCode);
            this.content.Controls.Add(this.state);
            this.content.Controls.Add(this.city);
            this.content.Controls.Add(this.address);
            this.content.Controls.Add(this.label1);
            this.content.Controls.Add(this.back);
            this.content.Controls.Add(this.next);
            this.content.Controls.Add(this.bunifuProgressBar1);
            this.content.Controls.Add(this.label3);
            this.content.Location = new System.Drawing.Point(295, 48);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1040, 816);
            this.content.TabIndex = 0;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label7.Location = new System.Drawing.Point(306, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "End  Time";
            // 
            // endTime
            // 
            this.endTime.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.endTime.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.endTime.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.endTime.BorderThickness = 1;
            this.endTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.endTime.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.endTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.endTime.isPassword = false;
            this.endTime.Location = new System.Drawing.Point(309, 511);
            this.endTime.Margin = new System.Windows.Forms.Padding(4);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(260, 50);
            this.endTime.TabIndex = 37;
            this.endTime.Text = "20:00";
            this.endTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.endTime.OnValueChanged += new System.EventHandler(this.endTime_OnValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label6.Location = new System.Drawing.Point(306, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Start Time";
            // 
            // startTime
            // 
            this.startTime.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.startTime.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.startTime.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.startTime.BorderThickness = 1;
            this.startTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.startTime.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.startTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.startTime.isPassword = false;
            this.startTime.Location = new System.Drawing.Point(309, 418);
            this.startTime.Margin = new System.Windows.Forms.Padding(4);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(260, 50);
            this.startTime.TabIndex = 35;
            this.startTime.Text = "19:00";
            this.startTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.startTime.OnValueChanged += new System.EventHandler(this.startTime_OnValueChanged);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(12, 511);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(260, 50);
            this.bunifuDatepicker1.TabIndex = 34;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 11, 25, 21, 46, 0, 0);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label5.Location = new System.Drawing.Point(9, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Event Ends";
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
            this.startDate.Location = new System.Drawing.Point(12, 418);
            this.startDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(260, 50);
            this.startDate.TabIndex = 32;
            this.startDate.Value = new System.DateTime(2019, 11, 22, 21, 46, 26, 778);
            this.startDate.onValueChanged += new System.EventHandler(this.startDate_onValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(9, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Event Starts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Date et l\'Heure";
            // 
            // zCode
            // 
            this.zCode.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.zCode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.zCode.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.zCode.BorderThickness = 1;
            this.zCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.zCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.zCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.zCode.isPassword = false;
            this.zCode.Location = new System.Drawing.Point(499, 237);
            this.zCode.Margin = new System.Windows.Forms.Padding(4);
            this.zCode.Name = "zCode";
            this.zCode.Size = new System.Drawing.Size(147, 59);
            this.zCode.TabIndex = 29;
            this.zCode.Text = "Code postal";
            this.zCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.zCode.OnValueChanged += new System.EventHandler(this.zCode_OnValueChanged);
            this.zCode.Enter += new System.EventHandler(this.zCodeenter);
            this.zCode.Leave += new System.EventHandler(this.zCodeleave);
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
            this.state.Location = new System.Drawing.Point(344, 237);
            this.state.Margin = new System.Windows.Forms.Padding(4);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(147, 59);
            this.state.TabIndex = 28;
            this.state.Text = "Organisateur";
            this.state.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.state.OnValueChanged += new System.EventHandler(this.state_OnValueChanged);
            this.state.Enter += new System.EventHandler(this.Organisateurenter);
            this.state.Leave += new System.EventHandler(this.Organisateurleave);
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
            this.city.Text = "Ville";
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.city.OnValueChanged += new System.EventHandler(this.city_OnValueChanged);
            this.city.Enter += new System.EventHandler(this.Villeenter);
            this.city.Leave += new System.EventHandler(this.Villeleave);
            // 
            // address
            // 
            this.address.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.address.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.address.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.address.BorderThickness = 1;
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.address.isPassword = false;
            this.address.Location = new System.Drawing.Point(9, 157);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(637, 59);
            this.address.TabIndex = 26;
            this.address.Text = "Adresse";
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.address.OnValueChanged += new System.EventHandler(this.address_OnValueChanged);
            this.address.Enter += new System.EventHandler(this.addressenter);
            this.address.Leave += new System.EventHandler(this.addressleave);
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
            this.label1.Text = "Étape 3 sur 4";
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
            this.back.Location = new System.Drawing.Point(159, 631);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(125, 47);
            this.back.TabIndex = 24;
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
            this.next.Location = new System.Drawing.Point(313, 631);
            this.next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(125, 47);
            this.next.TabIndex = 23;
            this.next.Click += new System.EventHandler(this.next_Click);
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
            this.label3.Size = new System.Drawing.Size(379, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Où se déroulera votre événement?";
            // 
            // CreatEvent3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.content);
            this.Name = "CreatEvent3";
            this.Size = new System.Drawing.Size(1682, 946);
            this.Load += new System.EventHandler(this.CreatEvent3_Load);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private Bunifu.Framework.UI.BunifuDatepicker startDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox zCode;
        private Bunifu.Framework.UI.BunifuMetroTextbox state;
        private Bunifu.Framework.UI.BunifuMetroTextbox city;
        private Bunifu.Framework.UI.BunifuMetroTextbox address;
        private System.Windows.Forms.Label label1;
        private JThinButton.JThinButton back;
        private JThinButton.JThinButton next;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox endTime;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox startTime;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label5;
    }
}
