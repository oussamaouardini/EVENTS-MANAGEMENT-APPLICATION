using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework;
using System.Data.SqlClient;

namespace MiniProjectFinal
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void email_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            String cs = @"Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
            SqlConnection myconnection = default(SqlConnection);
            myconnection = new SqlConnection(cs);
            myconnection.Open();
            try
            {

               
                


                // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                // con.Open();
                SqlCommand mycomand = default(SqlCommand);

                if (IsValidEmail(jMetroTextBox1.TextName.ToString()))
                {


                    mycomand = new SqlCommand("select email,password from EV_USER where email=@usnm and password=@psd", myconnection);
                    SqlParameter Uname = new SqlParameter("@usnm", SqlDbType.VarChar);
                    SqlParameter Upassword = new SqlParameter("@psd", SqlDbType.VarChar);
                    Uname.Value = jMetroTextBox1.TextName.ToString();
                    Upassword.Value = jMetroTextBox2.TextName.ToString();

                    mycomand.Parameters.Add(Uname);
                    mycomand.Parameters.Add(Upassword);
                   // mycomand.Connection.Open();
                    SqlDataReader myraeder = mycomand.ExecuteReader(CommandBehavior.CloseConnection);


                    if (myraeder.Read() == true)
                    {

                        //MessageBox.Show("vous vous êtes connecté avec succès");
                        Confirmation cf = new Confirmation("vous vous êtes connecté avec succès", Uname.Value.ToString(), Upassword.Value.ToString());
                        cf.Show();
                        if (cf.conf == true)
                        {
                            home hm = new home(Uname.Value.ToString(), Upassword.Value.ToString());
                            String query = " select *  FROM EVENEMENT where event_approve='true' order by id_ev asc";
                            homeUC nm = new homeUC(query, Uname.Value.ToString(), Upassword.Value.ToString());
                            nm.buttonNext_Clickseemore(sender, e);
                            hm.ShowDialog();
                            this.Close();
                            hm.homeUC1_Load(sender, e, "SELECT top 8 * FROM EVENEMENT where  event_approve = 'true' order by asc ", Uname.Value.ToString(), Upassword.Value.ToString());
                        }
                        // home hm = new home();

                    }
                    else
                    {
                        if (jMetroTextBox1.TextName.ToString() == "" || jMetroTextBox1.TextName.ToString() == "myemail@email.com")
                        {
                            jMetroTextBox1.BorderColor = Color.Red;
                        }

                        if (jMetroTextBox2.TextName.ToString() == "" || jMetroTextBox2.TextName.ToString() == "Enter votre mot de passe")
                        {
                            jMetroTextBox2.BorderColor = Color.Red;
                        }


                        //  MessageBox.Show("verifier votre username et password");
                        message ms = new message("Verifier E-mail ou Mot de passe", this.Name);
                        ms.Show();
                    }


                }
                else
                {
                    message ms = new message("Invalide E-mail Adresse", this.Name);
                    ms.Show();
                }





            }
            catch (SqlException ex)
            {
                //  MessageBox.Show(ex.Message);
                message ms = new message(ex.Message, this.Name);
                ms.Show();
            }







            myconnection.Close();




            ////////////////////////////////////////////////////

        }

        private void jMetroTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void jMetroTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void click_email(object sender, MouseEventArgs e)
        {

        }

        private void click_email_1(object sender, EventArgs e)
        {
            if (jMetroTextBox1.TextName.ToString() == "myemail@email.com")
                jMetroTextBox1.TextName = "";


        }

        private void click_email_2(object sender, EventArgs e)
        {
            if (jMetroTextBox1.TextName.ToString() == "")
                jMetroTextBox1.TextName = "myemail@email.com";
        }

        private void lev(object sender, EventArgs e)
        {
            if (jMetroTextBox2.TextName.ToString() == "")
                jMetroTextBox2.TextName = "enter your password";
        }



        private void entre(object sender, EventArgs e)
        {
            if (jMetroTextBox2.TextName.ToString() == "enter your password")
                jMetroTextBox2.TextName = "";
        }

        private void jMetroTextBox2_Load_1(object sender, EventArgs e)
        {

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


    }
}
