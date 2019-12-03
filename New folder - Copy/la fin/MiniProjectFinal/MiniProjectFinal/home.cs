using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectFinal
{
    
    public partial class home : Form
    {
        private String UserEmail;
        private String Userpass;

        public home()
        {
            InitializeComponent();
        }

        public home(String em, String pas)
        {
            InitializeComponent(em,pas);
            this.UserEmail = em;
            this.Userpass = pas;
           // button1.Text = em;
        }

        public home(String q)
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            homeUC1.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            homeUC hm = new homeUC(this.UserEmail, this.Userpass);
            homeUC1_Load(sender, e, "SELECT top 8 * FROM EVENEMENT where  event_approve = 'true'", this.UserEmail, this.Userpass);
            //   MainControlClass.showControl(hm, homeUC1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CreatEvent c1 = new CreatEvent();
            MainControlClass.showControl(c1, homeUC1);
        }
        private void homeUC1_Load(object sender, EventArgs e)
        {
         
        }

        private void homeUC1_Load(object sender, EventArgs e,String q)
        {
            homeUC hm = new homeUC(q,this.UserEmail,this.Userpass);
            MainControlClass.showControl(hm, homeUC1);
        }
        public void homeUC1_Load(object sender, EventArgs e, String q,String am,String P)
        {
            homeUC hm = new homeUC(q, this.UserEmail, this.Userpass);
            MainControlClass.showControl(hm, homeUC1);
        }

        private void homeUC1_Load(object sender, EventArgs e, String emai,String pass)
        {
            homeUC hm = new homeUC(emai,pass);
            MainControlClass.showControl(hm, homeUC1);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lev(object sender, EventArgs e)
        {
            
        }

        private void en(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            String query = "SELECT * FROM EVENEMENT where nom_Ev LIKE   '" + search.Text.ToString() + "%' order by nom_Ev asc ";
            homeUC1_Load(sender, e, query,this.UserEmail,this.Userpass);
        }

        private void bunienter(object sender, EventArgs e)
        {
            if (search.text.ToString() == "Que cherchez-vous ?")
                search.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homeUC hm = new homeUC(this.UserEmail, this.Userpass);
            homeUC1_Load(sender, e, "SELECT top 8 * FROM EVENEMENT where  event_approve = 'true'", this.UserEmail, this.Userpass);
         //   MainControlClass.showControl(hm, homeUC1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       

        private void button5_Click_2(object sender, EventArgs e)
        {
            String query = "SELECT * FROM EVENEMENT where type_Ev = 'Music'and event_approve='true' ";
            homeUC1_Load(sender, e, query, this.UserEmail, this.Userpass);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            String query = "SELECT * FROM EVENEMENT where  event_approve = 'true' and type_Ev = (select interests from EV_USER where email ='" + this.UserEmail + "') ";
            homeUC1_Load(sender, e, query, this.UserEmail, this.Userpass);
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            String query = "SELECT * FROM EVENEMENT where event_Status = 'public' and event_approve='true' ";
            homeUC1_Load(sender, e, query, this.UserEmail, this.Userpass);
        }

        private void button9_Click_2(object sender, EventArgs e)
        {

            String query = "  SELECT * FROM EVENEMENT where id_ev in (select eventID from LIKES where userID in( select id_user from EV_USER where email ='" + this.UserEmail + "' ) )  ";
            homeUC1_Load(sender, e, query, this.UserEmail, this.Userpass);
        }
    }
}
