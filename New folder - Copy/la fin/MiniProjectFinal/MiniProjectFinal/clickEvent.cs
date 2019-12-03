using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiniProjectFinal
{
    public partial class clickEvent : UserControl
    {
        private String connection = "Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True ";

        private String location;
        private String event_id;
        private String datedeb;
        private String datefin;
        private String nameevent;
        private String organisateur;
        private String prix;
        private String description;
        private String city;
        private String address;
        private String codepostal;
        private String user_em;
        private String user_p;

        public clickEvent()
        {
            InitializeComponent();
        }

        public clickEvent(String picloc, String id, String dtd, String dtf, String nomev, String auth, String prc, String dess, String ct, String Addr, String cod, String em, String pass)
        {
            InitializeComponent();
            this.user_em = em;
            this.user_p = pass;
            this.location = picloc;
            this.event_id = id;
            this.datedeb = dtd;
            this.datefin = dtf;
            this.nameevent = nomev;
            this.organisateur = auth;
            this.prix = prc;
            this.description = dess;
            pictureBox1.ImageLocation = picloc;
            this.city = ct;
            this.address = Addr;
            this.codepostal = cod;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = dtd;
            label2.Text = nomev;
            label3.Text = auth;
            label5.Text = dess;
            label15.Text = ct + "\n" + Addr + "\n" + cod+this.prix;
            label11.Text = dtd;
            label12.Text = dtf;
            /////////////////////////////////////////
            ///
            SqlConnection myeconc = new SqlConnection(connection);
            // SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-HL4O4OE;Initial Catalog=eventtest;Integrated Security=True");
            myeconc.Open();
            SqlDataAdapter SAe = new SqlDataAdapter("SELECT *  FROM LIKES ", myeconc);
            DataSet datss = new DataSet();
            SAe.Fill(datss);
            SqlCommand cmod = new SqlCommand("SELECT id_user FROM EV_USER WHERE email = '" + this.user_em + "' AND password = '" + this.user_p + "'", myeconc);
            int userID = (Int32)cmod.ExecuteScalar();



            if (datss.Tables[0].Rows.Count == 0)
            {

                // like button


                // love.Image 
                
                button2.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\like.png");
                // love.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\final one\heart");

            }
            else
            {
                string usr;
                string ev;
                Boolean gd = false;
                foreach (DataRow dLIK in datss.Tables[0].Rows)
                {
                    usr = dLIK["userID"].ToString();
                    ev = dLIK["eventID"].ToString();




                    if (usr == userID.ToString() && ev == this.event_id)
                    {
                        button2.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\likes.png");
                        gd = true;
                        break;
                    }
                    //else
                    if (!gd)
                    {
                        button2.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\like.png");
                    }


                }
            }


            myeconc.Close();
        }

        private void jThinButton4_Click(object sender, EventArgs e)
        {
            TicketRe tk = new TicketRe(this.nameevent,this.location,this.event_id,this.datedeb,this.datedeb,this.address,this.prix,this.datefin,this.user_em,this.user_p);
            tk.ShowDialog();

        }

        private void clickEvent_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection(connection);
                con.Open();
                String query1 = " insert into LIKES(userId,eventId) select id_user,'" + this.event_id + "' from EV_USER WHERE email='" + this.user_em + "'   ";

                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                //  MessageBox.Show("liked this image");
                con.Close();
                //String picloc, String id, String dtd, String dtf, String nomev, String auth, String prc, String dess, String ct, String Addr, String cod, String em, String pass)
                clickEvent cl = new clickEvent(this.location,this.event_id,this.datedeb,this.datefin,this.nameevent,this.organisateur,this.prix,this.description,this.city,this.address,this.codepostal,this.user_em, this.user_p);
                MainControlClass.showControl(cl,this);

                // this.Refresh();
                con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
