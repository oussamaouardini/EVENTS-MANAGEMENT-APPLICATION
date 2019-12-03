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

namespace MiniProjectFinal
{
    public partial class SignUp : Form
    {


        Boolean nm = true;
        Boolean pr = true;
        Boolean vl = true;
        Boolean cp = true;
        Boolean em = true;
        Boolean md = true;
        Boolean tl = true;
        Boolean ci = true;



        public SignUp()
        {
            InitializeComponent();
            srv.Parent = pictureBox1;
            srv.BackColor = Color.Transparent;

            stf.Parent = pictureBox1;
            stf.BackColor = Color.Transparent;

            hd.Parent = pictureBox1;
            hd.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            service.Parent = pictureBox1;
            service.BackColor = Color.Transparent;
            service1.Parent = pictureBox1;
            service1.BackColor = Color.Transparent;
            service2.Parent = pictureBox1;
            service2.BackColor = Color.Transparent;
            service3.Parent = pictureBox1;
            service3.BackColor = Color.Transparent;

            staff.Parent = pictureBox1;
            staff.BackColor = Color.Transparent;
            staff1.Parent = pictureBox1;
            staff1.BackColor = Color.Transparent;
            staff2.Parent = pictureBox1;
            staff2.BackColor = Color.Transparent;
            staff3.Parent = pictureBox1;
            staff3.BackColor = Color.Transparent;

            hand.Parent = pictureBox1;
            hand.BackColor = Color.Transparent;
            hand1.Parent = pictureBox1;
            hand1.BackColor = Color.Transparent;
            hand2.Parent = pictureBox1;
            hand2.BackColor = Color.Transparent;
            hand3.Parent = pictureBox1;
            hand3.BackColor = Color.Transparent;


        }


        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void interests_onItemSelected(object sender, EventArgs e)
        {


        }

        private void sinsc_Click(object sender, EventArgs e)
        {



            if (nn.TextName.ToString() == "" || nn.TextName.ToString() == "Entrer votre nom")
            {
                nn.BorderColor = Color.Red;
                nm = false;
            }

            if (pp.TextName.ToString() == "" || pp.TextName.ToString() == "Entrer votre prenom")
            {
                pp.BorderColor = Color.Red;
                pr = false;
            }
            if (vv.TextName.ToString() == "" || vv.TextName.ToString() == "Entrer votre ville")
            {
                vv.BorderColor = Color.Red;
                vl = false;
            }
            if (cc.TextName.ToString() == "" || cc.TextName.ToString() == "Entrer le Code Postale")
            {
                cc.BorderColor = Color.Red;
                cp = false;

            }

            if (email.TextName.ToString() == "" || email.TextName.ToString() == "Entrer votre adresse email")
            {
                email.BorderColor = Color.Red;
                em = false;
            }

            if (passs.TextName.ToString() == "" || passs.TextName.ToString() == "Entrer votre mot de passe")
            {
                passs.BorderColor = Color.Red;
                md = false;
            }
            if (tele.TextName.ToString() == "" || tele.TextName.ToString() == "Entrer votre Tele")
            {
                tele.BorderColor = Color.Red;
                tl = false;
            }

            if (cin.TextName.ToString() == "" || cin.TextName.ToString() == "Entrer votre CIN")
            {
                cin.BorderColor = Color.Red;
                ci = false;
            }



            if (nm && pr && vl && cp && em && md && tl && ci)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                con.Open();

                try
                {

                   
                    int zipcode;
                    Int32.TryParse(cc.Text, out zipcode);

                    if (IsValidEmail(email.TextName.ToString()))
                    {
                        string query = "insert into EV_USER (nom,prenom,interests,email,numerotel,password,zipCode,cin) values ('" + nn.TextName.ToString() + "','" + pp.TextName.ToString() + "','" + interestss.selectedValue.ToString() + "','" + email.TextName.ToString() + "','" + tele.TextName.ToString() + "','" + passs.TextName.ToString() + "','" + zipcode + "','" + cin.TextName.ToString() + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        sda.SelectCommand.ExecuteNonQuery();
                       // con.Close();
                        Confirmation c = new Confirmation("inscription réussie, vous pouvez vous connecter maintenant");
                        c.Show();
                        // MessageBox.Show("inserted succesfully");
                        //  this.Hide();
                    }
                    else
                    {
                        message m = new message("Adresse E-mail Invalide", this.Name);
                        m.Show();
                    }






                }
                catch (SqlException ex)
                {
                    //  MessageBox.Show(ex.Message);
                    message m = new message(ex.Message, this.Name);
                    m.Show();
                }
                con.Close();
            }
            else
            {
                message m = new message("Champs de saisie Invalides !!", this.Name);
                m.Show();

                // MessageBox.Show();
            }




        }

        private void n_TextChanged(object sender, EventArgs e)
        {

        }

        private void em_TextChanged(object sender, EventArgs e)
        {

        }

        private void tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_TextChanged(object sender, EventArgs e)
        {

        }

        private void ci_TextChanged(object sender, EventArgs e)
        {

        }

        private void leave(object sender, EventArgs e)
        {
            if (nn.TextName.ToString() == "")
                nn.TextName = "Entrer votre nom";
        }

        private void enter(object sender, EventArgs e)
        {
            if (this.nm == false)
            {
                nn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));

            }

            if (nn.TextName.ToString() == "Entrer votre nom")
                nn.TextName = "";
            this.nm = true;
        }

        private void pleave(object sender, EventArgs e)
        {

            if (pp.TextName.ToString() == "")
                pp.TextName = "Entrer votre prenom";

        }

        private void penter(object sender, EventArgs e)
        {
            if (this.pr == false)
            {
                pp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));

            }


            if (pp.TextName.ToString() == "Entrer votre prenom")
                pp.TextName = "";
            this.pr = true;
        }

        private void vleave(object sender, EventArgs e)
        {
            if (vv.TextName.ToString() == "")
                vv.TextName = "Entrer votre ville";
        }

        private void venter(object sender, EventArgs e)
        {
            if (this.vl == false)
            {
                vv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));

            }


            if (vv.TextName.ToString() == "Entrer votre ville")
                vv.TextName = "";
            this.vl = true;
        }

        private void posleave(object sender, EventArgs e)
        {
            if (cc.TextName.ToString() == "")
                cc.TextName = "Entrer le Code Postale";
        }

        private void posenter(object sender, EventArgs e)
        {
            if (this.cp == false)
            {
                cc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));

            }

            if (cc.TextName.ToString() == "Entrer le Code Postale")
                cc.TextName = "";
            this.cp = true;
        }

        private void emailleave(object sender, EventArgs e)
        {
            if (email.TextName.ToString() == "")
                email.TextName = "Entrer votre adresse email";
        }

        private void emailenter(object sender, EventArgs e)
        {
            if (this.em == false)
            {
                email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));

            }

            if (email.TextName.ToString() == "Entrer votre adresse email")
                email.TextName = "";
            this.em = true;
        }

        private void passsleave(object sender, EventArgs e)
        {
            if (passs.TextName.ToString() == "")
                passs.TextName = "Entrer votre mot de passe";
        }

        private void passsenter(object sender, EventArgs e)
        {

            if (this.md == false)
            {
                passs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));

            }

            if (passs.TextName.ToString() == "Entrer votre mot de passe")
                passs.TextName = "";
            this.md = true;
        }

        private void teleleave(object sender, EventArgs e)
        {
            if (tele.TextName.ToString() == "")
                tele.TextName = "Entrer votre Tele";
        }

        private void teleenter(object sender, EventArgs e)
        {
            if (this.tl == false)
            {
                tele.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));

            }


            if (tele.TextName.ToString() == "Entrer votre Tele")
                tele.TextName = "";
            this.tl = true;
        }

        private void cinleave(object sender, EventArgs e)
        {

            if (cin.TextName.ToString() == "")
                cin.TextName = "Entrer votre CIN";
        }

        private void cinenter(object sender, EventArgs e)
        {
            if (this.ci == false)
            {
                cin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));

            }

            if (cin.TextName.ToString() == "Entrer votre CIN")
                cin.TextName = "";
            this.ci = true;
        }

        private void nn_Load(object sender, EventArgs e)
        {
            //Boolean nm = true;
            //Boolean pr = true;





            //Boolean vl = true;
            //Boolean cp = true;
            //Boolean em = true;
            //Boolean md = true;
            //Boolean tl = true;
            //Boolean ci = true;238, 235, 235

        }

        private void passs_Load(object sender, EventArgs e)
        {

        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }

        }
        private void keypress(object sender, KeyPressEventArgs e)
        {
          //  MessageBox.Show("la3vkfo");


        }

        private void interestss_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
