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
    public partial class CreditCard : UserControl
    {
        String email;
        String pass;
        String eventid;
        int nbe;
        public CreditCard()
        {
            InitializeComponent();
        }

        public CreditCard(String str , String em, String pa,String id,int n)
        {
            InitializeComponent();
            label29.Text = str;
            this.email = em;
            this.pass = pa;
            this.eventid = id;
            this.nbe = n;
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if(bunifuMetroTextbox1.Text.Length >= 4)
            {

                cardType.Visible = true;
                if (bunifuMetroTextbox1.Text.Substring(0,4).Equals("4552"))
            {
                cardType.ImageLocation = @"C:\Users\sparo\Desktop\2ème année\S3\BD-C#\BD avancée\pictures\visa.png";

            }
            else if (bunifuMetroTextbox1.Text.Substring(0, 4).Equals("5321"))
            {
                cardType.ImageLocation = @"C:\Users\sparo\Desktop\2ème année\S3\BD-C#\BD avancée\pictures\mastercard.png";
            }
            else
            {
                cardType.Visible = false;
            }
            }
            //if(bunifuMetroTextbox1.Text.Equals(""))
            else
            {
                cardType.Visible = false;
            }
        }

        private void bunifuMetroTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void CreditCard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void bunifuMetroTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(this.eventid);
            string coonection = "Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
            SqlConnection con = new SqlConnection(coonection);
            con.Open();
            /*
            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT dbo.[checkTicketAvailable](@nbticket,@idevent)";
            cmd.Parameters.AddWithValue("@nbticket", this.nbe);
            cmd.Parameters.AddWithValue("@idevent", this.eventid);
            int index = (Int32)cmd.ExecuteScalar();*/
        
            try
            {
               
                    string query = "insert into PURCHAS(id_user,id_ev) select id_user,'" + this.eventid + "' from EV_USER where email='" + this.email + "' and password='" + this.pass + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    //  con.Close();
                    //   MessageBox.Show("inserted succesfully events");
                    // con.Open();
                    string query1 = "Update TICKETSTOCK SET t_available = t_available -" + this.nbe + " where id_evticket = '" + this.eventid + "' ";
                    SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                    sda1.SelectCommand.ExecuteNonQuery();
                    // con.Close();
                    //   MessageBox.Show("inserted succesfully ticket");
                    //    con.Open();
                    string query2 = "Update TICKETSTOCK SET t_taken = t_taken +" + this.nbe + " where id_evticket = '" + this.eventid + "' ";
                    SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                    sda2.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Payement Avec Succes");
                
                
               

                
              //  con.Close();
            }
            catch (SqlException ex)
            {
                //  MessageBox.Show(ex.Message);
                message m = new message(ex.Message, this.Name);
                m.Show();
            }

            con.Close();

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}
