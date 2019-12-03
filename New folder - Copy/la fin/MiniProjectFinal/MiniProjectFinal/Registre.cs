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
    public partial class Registre : UserControl
    {
        String prcccc;
        int rand;
        String totalll;
        String userem;
        String userpass;
        String id_events;

        public Registre()
        {
            InitializeComponent();
            label14.Text = numericUpDown1.Value.ToString();
        }
        public Registre(String nm,String imgloc, String Ev_id, String dtb, String orga, String add, String price,String dtf,String m , String p)
        {
            this.prcccc = price;
            this.userem = m;
            this.userpass = p;
            this.id_events = Ev_id;
            InitializeComponent();
            pictureBox1.ImageLocation = imgloc;
            label9.Text = nm;
            label10.Text = dtb;
            label7.Text = dtf;
            label2.Text = price + "$";
            label16.Text = price;
            
            label14.Text = numericUpDown1.Value.ToString();
            double prc;
            Double.TryParse(price, out prc);
            int nb;
            Int32.TryParse(numericUpDown1.Value.ToString(), out nb);
            label20.Text = "$"+prc * nb ;
            label23.Text = "$" + prc * nb;
            Random r = new Random();
            this.rand = r.Next(0, 40);
            label3.Text = this.rand  + " $";
            label25.Text = this.rand + " $";
            double tot = this.rand + prc * nb;
            label29.Text = tot + " $";
            this.totalll = tot + " $";

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int nbe;
            Int32.TryParse(numericUpDown1.Value.ToString(), out nbe);

            string coonection = "Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
            SqlConnection con = new SqlConnection(coonection);
            con.Open();

            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT dbo.[checkTicketAvailable](@nbticket,@idevent)";
            cmd.Parameters.AddWithValue("@nbticket", nbe);
            cmd.Parameters.AddWithValue("@idevent", this.id_events);
            int index = (Int32)cmd.ExecuteScalar();
            if (index == 1)
            {
                CreditCard cd = new CreditCard(this.totalll, this.userem, this.userpass, this.id_events, nbe);
                MainControlClass.showControl(cd, panel1);
            }
            else
            {
                MessageBox.Show("Le nombre de ticket que vous avez saisi n'est pas encore valable ");
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label14.Text = numericUpDown1.Value.ToString();
            label14.Text = numericUpDown1.Value.ToString();
            double prc;
            Double.TryParse(this.prcccc, out prc);
            int nb;
            Int32.TryParse(numericUpDown1.Value.ToString(), out nb);
            label20.Text = "$" + prc * nb;
            label23.Text = "$" + prc * nb;

            double tot = this.rand + prc * nb;
            label29.Text = tot + " $";
            this.totalll = tot + " $";

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
