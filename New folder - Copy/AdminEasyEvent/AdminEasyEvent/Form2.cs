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
    public partial class msgbx : Form
    {
        private String msx;
        private int id;
        private String ev_nm;
        private String ev_typ;
        public msgbx()
        {
            InitializeComponent();
        }
        public msgbx(String ms)
        {
            InitializeComponent();
            this.msx = ms;
            label1.Text = ms;
            //this.id = i;
        }

        public msgbx(String ms,int i, String nm, String T)
        {
            InitializeComponent();
            this.msx = ms;
            label1.Text = ms;
            this.id = i;
            this.ev_nm = nm;
            this.ev_typ = T;
        }



        private void msgbx_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                conn.Open();

                SqlCommand mycomand = default(SqlCommand);
                String query1 = " insert into Historique(id_Event,nomEvent,typeEvent) values('"+this.id+"','"+this.ev_nm+"','"+this.ev_typ+"') ";
                String query = "delete from EVENEMENT where id_ev =" + this.id;
                SqlDataAdapter sda = new SqlDataAdapter(query1, conn);
                SqlDataAdapter sda1 = new SqlDataAdapter(query, conn);
               // sda.SelectCommand.ExecuteNonQuery();
                sda1.SelectCommand.ExecuteNonQuery();
                this.Hide();
                okform m = new okform("événement supprimé avec succès");
                m.Show();

            }
            catch(SqlException ex)
            {
                msgbx m = new msgbx(ex.ToString());
                m.Show();
            }
            
            
        }
    }
}
