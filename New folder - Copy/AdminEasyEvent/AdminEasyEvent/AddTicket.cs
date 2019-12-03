using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProjectFinal;
using System.Data.SqlClient;

namespace AdminEasyEvent
{
    public partial class AddTicket : UserControl
    {
        public AddTicket()
        {
            InitializeComponent();
            int x = 43;
           
            int z = 130;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM EVENEMENT", conn);
            SDA.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                PictureBox pic1 = new PictureBox();
                pic1.ImageLocation = dr["imglocation"].ToString();
                pic1.Width = 350;
                pic1.Height = 126;
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                pic1.Location = new Point(x, z);

                //Column 1
                Label date = new Label();
                date.Text = dr["startDate"].ToString();
                date.Location = new Point(pic1.Width + 60, z);
                date.AutoSize = true;
                date.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(20)))));
                date.Size = new System.Drawing.Size(106, 22);
                date.TabIndex = 24;

                // Column 2
                Label title = new Label();
                title.Text = dr["nom_Ev"].ToString();
                title.Location = new Point(pic1.Width + 60, z + 30);
                title.AutoSize = true;
                title.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.ForeColor = System.Drawing.Color.Black;
                title.Size = new System.Drawing.Size(435, 44);
                title.TabIndex = 23;


                // Column 3
                Label author = new Label();
                author.Text = dr["organisateur"].ToString();
                author.Location = new Point(pic1.Width + 60, z + 60);
                author.AutoSize = true;
                author.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                author.ForeColor = System.Drawing.Color.Gray;
                author.Size = new System.Drawing.Size(103, 16);
                author.TabIndex = 25;


                // Column 4
                Label price = new Label();
                price.Location = new Point(pic1.Width + 60, z + 90);
                price.AutoSize = true;
                price.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                price.ForeColor = System.Drawing.Color.Gray;
                price.Size = new System.Drawing.Size(88, 16);
                price.TabIndex = 26;
                price.Text = "Starts at 100$";

                //Button
                JThinButton.JThinButton delete = new JThinButton.JThinButton();
                delete.BackColor = System.Drawing.Color.Transparent;
                delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
                delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
                delete.BorderRadius = 5;
                delete.ButtonText = "Add Ticket";
                delete.Font = new System.Drawing.Font("Montserrat ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                delete.Font_Size = new System.Drawing.Font("Montserrat ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                delete.ForeColors = System.Drawing.Color.White;
                delete.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
                delete.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
                delete.HoverFontColor = System.Drawing.Color.White;
                delete.LineThickness = 2;
                delete.Location = new System.Drawing.Point(1345, z + 35);
                delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                delete.Size = new System.Drawing.Size(262, 51);
                delete.TabIndex = 27;

                //Separator
                Label label3 = new Label();
                label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                label3.Cursor = System.Windows.Forms.Cursors.Default;
                label3.Location = new System.Drawing.Point(x, z + 150);
                label3.Size = new System.Drawing.Size(1564, 2);
                label3.TabIndex = 29;



                //Button delete = new Button();
                //delete.Text = "Delete";
                //delete.Location = new Point(pic1.Width + 20, y);

                //Label separator = new Label();
                //separator.Text = " ";
                //separator.Location = new Point(x, y);


                // ...
                // Other columns
                // ...
                //y += date.Height + 5;
                z += pic1.Height + 50;
                this.Controls.Add(pic1);
                this.Controls.Add(date);
                this.Controls.Add(title);
                this.Controls.Add(author);
                this.Controls.Add(price);
                this.Controls.Add(delete);
                this.Controls.Add(label3);
                //this.Controls.Add(delete);
                //this.Controls.Add(separator);
                // Add other labels
            }
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            Tickets tk = new Tickets();
            tk.ShowDialog();
        }

        private void jThinButton2_Click(object sender, EventArgs e)
        {
            Tickets tk = new Tickets();
            tk.ShowDialog();
        }

        private void jThinButton3_Click(object sender, EventArgs e)
        {
            Tickets tk = new Tickets();
            tk.ShowDialog();
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
