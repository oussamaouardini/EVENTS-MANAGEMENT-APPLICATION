using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminEasyEvent
{
    public partial class okannuler : Form
    {
        private String msg;
        private int id;
        String lb="";
        public okannuler()
        {
            InitializeComponent();
        }
        public okannuler(String m )
        {
            InitializeComponent();
            this.msg = m;
            //this.lb = "login";
        }
        public okannuler(String m,String l)
        {
            InitializeComponent(l);
            this.msg = m;
            this.lb = l;
            jThinButton1.ButtonText = "ok";
            label1.Text = m;
            //jThinButton1.Location.X = 320;
           // MessageBox.Show("vvvvvvvvvvvv");


        }

        public okannuler(String m,int i)
        {
            InitializeComponent();
            this.msg = m;
            this.id = i;
            label1.Text = m;
           // MessageBox.Show("vvvvvvvvvvvvddddddddddd");
        }
        


        private void okannuler_Load(object sender, EventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            if (this.lb=="login")
            {
                this.Hide();

            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                    conn.Open();

                    SqlCommand mycomand = default(SqlCommand);
                    String query = " update EVENEMENT set event_approve='true' where id_ev =" + this.id;

                    SqlDataAdapter sda1 = new SqlDataAdapter(query, conn);
                    sda1.SelectCommand.ExecuteNonQuery();
                    this.Hide();
                    okform m = new okform("Evénement Approuver avec succès");
                    m.Show();

                }
                catch (SqlException ex)
                {
                    msgbx m = new msgbx(ex.ToString());
                    m.Show();
                }
            }

            





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
