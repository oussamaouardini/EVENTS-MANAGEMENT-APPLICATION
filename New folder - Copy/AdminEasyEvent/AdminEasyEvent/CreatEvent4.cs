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
using System.IO;

namespace MiniProjectFinal
{
    public partial class CreatEvent4 : UserControl
    {
        private String type2;
        private String nom2;
        private String add;
        private String city;
        private String state;
        private String code;
        private String datedebu;
        private String datedebutime;
        private String datefin;
        private String datefintime;
        private String statu;
        private String prix;
        private String nombre;
        private String desc;
        private String imageLocation = "";


        private Boolean img = false;

        public CreatEvent4()
        {
            InitializeComponent();
        }

        public CreatEvent4(String t, String n, String ad, String ci, String sta, String codepostal, String dtb, String dtbti, String dfin, String dfintime, String stat, String prx , String num)
        {
            InitializeComponent();
            this.type2 = t;
            this.nom2 = n;
            this.add = ad;
            this.city = ci;
            this.state = sta;
            this.code = codepostal;
            this.datedebu = dtb;
            this.datedebutime = dtbti;
            this.datefin = dfin;
            this.datefintime = dfintime;
            this.statu = stat;
            this.prix = prx;
            this.nombre =num;
            this.desc = dess.Text.ToString();
    }



        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.*";
                // dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*|";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    button1.BackgroundImage = Image.FromFile(imageLocation);
                    // button1.AutoSi
                    this.img = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void address_OnValueChanged(object sender, EventArgs e)
        {
           // label5.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            CreatEvent3 c3 = new CreatEvent3();
            UserControl1 u1 = new UserControl1(this.type2,this.nom2,this.add,this.city,this.state,this.code,this.datedebu,this.datefin,this.datedebutime,this.datefintime);
            MainControlClass.showControl(u1, this);
        }

        private void next_Click(object sender, EventArgs e)
        {

            try
            {

                byte[] images = null;
                
                
                if(this.img == true)
                {


                    FileStream streem = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(streem);
                    images = brs.ReadBytes((int)streem.Length);

                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                    con.Open();
                    String query1 = " insert into LOCALISATION(city,adress,codepostal) values ('" + this.city + "','" + this.add + "','" + this.code + "')  ";

                    SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                    sda1.SelectCommand.ExecuteNonQuery();
                    con.Close();


                    String query2 = " insert into EVENEMENT(id_localisation,description,organisateur,startDate,endDate,type_Ev,nom_Ev,imglocation,event_approve,image) select id_city,'" + dess.Text.ToString() + "','" + this.state + "','" + this.datedebu + "','" + this.datefin + "','" + this.type2 + "','" + this.nom2 + "','" + imageLocation + "','true','@images' from LOCALISATION where LOCALISATION.city='" + this.city + "' and LOCALISATION.adress='"+this.add+"' ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query2, con);
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    int N = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(N.ToString() + "data saved succ...");

                    int number;

                    bool success = Int32.TryParse(this.nombre.ToString(), out number);



                    String query3 = " insert into TICKETSTOCK (id_evticket,t_available,t_taken) select top 1 id_ev ,'" + number + "',0 from EVENEMENT order BY id_ev DESC";
                    con.Open();
                    SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
                    sda3.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Inserted succsesfully");








                }
                else
                {
                    MessageBox.Show("import event iamge");
                }
               
                   
                
                


              












            }
            catch ( SqlException ex )
            {
                MessageBox.Show(ex.ToString());
            }




















        }

        private void CreatEvent4_Load(object sender, EventArgs e)
        {

        }

        private void dess_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
