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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {



            try
            {

                String cs = @"Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
                SqlConnection myconnection = default(SqlConnection);
                myconnection = new SqlConnection(cs);


                // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                // con.Open();
                SqlCommand mycomand = default(SqlCommand);

                if (IsValidEmail(username.Text.ToString()))
                {


                    mycomand = new SqlCommand("select email,password from Admin where email=@usnm and password=@psd", myconnection);
                    SqlParameter Uname = new SqlParameter("@usnm", SqlDbType.VarChar);
                    SqlParameter Upassword = new SqlParameter("@psd", SqlDbType.VarChar);
                    Uname.Value = username.Text.ToString();
                    Upassword.Value = password.Text.ToString();

                    mycomand.Parameters.Add(Uname);
                    mycomand.Parameters.Add(Upassword);
                    mycomand.Connection.Open();
                    SqlDataReader myraeder = mycomand.ExecuteReader(CommandBehavior.CloseConnection);


                    if (myraeder.Read() == true)
                    {

                        //MessageBox.Show("vous vous êtes connecté avec succès");
                        okform cf = new okform("vous vous êtes connecté avec succès",2);
                        cf.Show();
                        if (cf.conf == true)
                        {
                            Dashboard dss = new Dashboard();
                            dss.ShowDialog();
                            this.Close();
                        }
                        // home hm = new home();

                    }
                    else
                    {
                        if ( username.Text.ToString() == "" || username.Text.ToString() == "myemail@email.com")
                        {
                            username.BorderColorIdle  = Color.Red;
                        }

                        if (password.Text.ToString() == "" || password.Text.ToString() == "Enter votre mot de passe")
                        {
                            password.BorderColorIdle = Color.Red;
                        }


                        //  MessageBox.Show("verifier votre username et password");

                      //  message ms = new message("Verifier E-mail ou Mot de passe", this.Name);
                        okannuler ms = new okannuler("Verifier E-mail ou Mot de passe","login");
                        ms.Show();
                    }


                }
                else
                {
                    //message ms = new message("Invalide E-mail Adresse", this.Name);
                    okannuler ms = new okannuler("Invalide E-mail Adresse", "login");
                    ms.Show();
                }





            }
            catch (SqlException ex)
            {
                //  MessageBox.Show(ex.Message);
                okannuler ms =  new okannuler(ex.Message);
               // message ms = new message(ex.Message, this.Name);
                ms.Show();
            }

































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

        private void username_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void password_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
