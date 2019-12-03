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
using System.Globalization;

namespace AdminEasyEvent
{
    public partial class Grraph : UserControl
    {
        public Grraph()
        {
            InitializeComponent();

            label1.Text = DateTime.Now.ToString();

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter SDA = new SqlDataAdapter("select count(*) as nb from EV_USER", conn);
                SDA.Fill(ds);
                foreach (DataRow dr in ds.Tables[0].Rows){  label7.Text = dr["nb"].ToString(); ;}


                DataSet db = new DataSet();
                SqlDataAdapter SDAb = new SqlDataAdapter("select count(*) as nb from EVENEMENT", conn);
                SDAb.Fill(db);
                foreach (DataRow drs in db.Tables[0].Rows) { label10.Text = drs["nb"].ToString(); ; }



                DataSet dbs = new DataSet();
                SqlDataAdapter SDAbs = new SqlDataAdapter("select count(*) as nbs from EVENEMENT where event_approve='true'", conn);
                SDAbs.Fill(dbs);
                foreach (DataRow drss in dbs.Tables[0].Rows) { label12.Text = drss["nbs"].ToString(); ; }


                DataSet dbsa = new DataSet();
                SqlDataAdapter SDAbsa = new SqlDataAdapter("select count(*) as nbs from Historique ", conn);
                SDAbsa.Fill(dbsa);
                foreach (DataRow drssa in dbsa.Tables[0].Rows) { label14.Text = drssa["nbs"].ToString(); ; }


            }
            catch (SqlException ex)
            {
                msgbx m = new msgbx(ex.ToString());
                m.Show();
            }







            // label7.Text = "88";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Grraph_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
