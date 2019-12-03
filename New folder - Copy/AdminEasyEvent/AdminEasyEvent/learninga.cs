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
    public partial class learninga : UserControl
    {

        public learninga(String ms)
        {
            InitializeComponent();
            String connec = "Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connec);
            conn.Open();

            try
            {

                int x = 20;
                int z = 60;
                // 54, 317

                
                DataSet ds = new DataSet();
                SqlDataAdapter SDA = new SqlDataAdapter(ms, conn);
                SDA.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    // z += pic1.Height + 50; 315, 159




                    /// to get the event id 

                    Label id = new Label();
                    id.Text = dr["id_ev"].ToString();



                    // pcture box and its propeties
                    PictureBox pic1 = new PictureBox();
                    pic1.Width = 350;
                    pic1.Height = 126;
                    if (x > 1500)
                    {
                        //  z += pic1.Height;
                        x = 20;
                        z += pic1.Height + 150;
                        //  z = 1000;

                    }
                    pic1.ImageLocation = dr["imglocation"].ToString();

                    pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic1.Location = new Point(x, z);
                    // pic1.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, pic1.ImageLocation, id.Text); };

                    //Column 1
                    Label date = new Label();
                    date.Text = dr["startDate"].ToString();
                    date.Location = new Point(x, pic1.Height + z);
                    date.AutoSize = true;
                    date.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(20)))));
                    date.Size = new System.Drawing.Size(106, 22);
                    date.TabIndex = 24;


                    //end date
                    Label datef = new Label();
                    datef.Text = dr["endDate"].ToString();
                    datef.Location = new Point(x, pic1.Height + z);
                    datef.AutoSize = true;
                    datef.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    datef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(20)))));
                    datef.Size = new System.Drawing.Size(106, 22);
                    datef.TabIndex = 24;

                    // Column 2
                    Label title = new Label();
                    title.Text = dr["nom_Ev"].ToString();
                    title.Location = new Point(x, pic1.Height + z + 30);
                    title.AutoSize = true;
                    title.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    title.ForeColor = System.Drawing.Color.Black;
                    title.Size = new System.Drawing.Size(435, 44);
                    title.TabIndex = 23;

                    // description
                    Label desc = new Label();
                    desc.Text = dr["description"].ToString();
                    desc.Location = new Point(x, pic1.Height + z + 30);
                    desc.AutoSize = true;
                    desc.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    desc.ForeColor = System.Drawing.Color.Black;
                    desc.Size = new System.Drawing.Size(435, 44);
                    desc.TabIndex = 23;


                    // city id
                    Label cityid = new Label();
                    cityid.Text = dr["id_localisation"].ToString();
                    cityid.Location = new Point(x, pic1.Height + z + 30);
                    cityid.AutoSize = true;

                    /* get localisatin detaills */
                 //   SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                  //  mycon.Open();
                    DataSet dats = new DataSet();
                    int idloc;
                    Int32.TryParse(cityid.Text, out idloc);
                    SqlDataAdapter SaDA = new SqlDataAdapter("SELECT *  FROM Localisation where id_city=" + idloc,conn);
                    SaDA.Fill(dats);

                    String Cityname = "";
                    String Address = "";
                    String Codepos = "";
                    foreach (DataRow d in dats.Tables[0].Rows)
                    {
                        Cityname = d["city"].ToString();
                        Address = d["adress"].ToString();
                        Codepos = d["codepostal"].ToString();
                    }





                    // like button

                    JThinButton.JThinButton love = new JThinButton.JThinButton();
                    love.Size = new System.Drawing.Size(32, 24);
                    // love.Location();
                    love.BackColor = System.Drawing.Color.Transparent;
                    love.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
                    love.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));

                    love.Location = new System.Drawing.Point(x + pic1.Width - 20, pic1.Height + z + 35);

                    // Column 3

                    Label author = new Label();
                    author.Text = dr["organisateur"].ToString();
                    author.Location = new Point(x, pic1.Height + z + 60);
                    author.AutoSize = true;
                    author.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    author.ForeColor = System.Drawing.Color.Gray;
                    author.Size = new System.Drawing.Size(103, 16);
                    author.TabIndex = 25;


                    // Column 4
                    Label price = new Label();
                    price.Location = new Point(x, pic1.Height + z + 90);
                    price.AutoSize = true;
                    price.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    price.ForeColor = System.Drawing.Color.Gray;
                    price.Size = new System.Drawing.Size(88, 16);
                    price.TabIndex = 26;
                    price.Text = "Starts at 100$";

                    //Button
                    JThinButton.JThinButton delete = new JThinButton.JThinButton();
                    delete.BackColor = System.Drawing.Color.Transparent;
                    delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
                    delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
                    delete.BorderRadius = 5;
                    delete.ButtonText = "Remove";
                    delete.Font = new System.Drawing.Font("Montserrat ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    delete.Font_Size = new System.Drawing.Font("Montserrat ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    delete.ForeColors = System.Drawing.Color.White;
                    delete.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
                    delete.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
                    delete.HoverFontColor = System.Drawing.Color.White;
                    delete.LineThickness = 2;
                    delete.Location = new System.Drawing.Point(x, pic1.Height + z + 35);
                    delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                    delete.Size = new System.Drawing.Size(262, 51);
                    delete.TabIndex = 27;
                    //  delete.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, id.Text); };
                    // delete.Click += delete_Click;

                    //Separator
                    Label label3 = new Label();
                    label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    label3.Cursor = System.Windows.Forms.Cursors.Default;
                    label3.Location = new System.Drawing.Point(pic1.Width + 100, z);
                    label3.Size = new System.Drawing.Size(2, 210);
                    label3.TabIndex = 29;



                    //Button delete = new Button();
                    //delete.Text = "Delete";
                    //delete.Location = new Point(pic1.Width + 20, y);

                    //Label separator = new Label();
                    //separator.Text = " ";
                    //separator.Location = new Point(x, y);


                    pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic1.Location = new Point(x, z);
                    pic1.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, pic1.ImageLocation, id.Text, date.Text.ToString(), datef.Text.ToString(), title.Text.ToString(), author.Text.ToString(), price.Text.ToString(), desc.Text.ToString(), Cityname.ToString(), Address.ToString(), Codepos.ToString()); };

                    // ...
                    // Other columns
                    // ...
                    //y += date.Height + 5;
                    // z += pic1.Height + 50; 
                    x += pic1.Width + 50;
                    this.Controls.Add(pic1);
                    this.Controls.Add(date);
                    this.Controls.Add(title);
                    // this.Controls.Add(author);
                    //   this.Controls.Add(price);
                    //  this.Controls.Add(delete);
                   // this.Controls.Add(label3);
                  //  this.Controls.Add(love);
                    //this.Controls.Add(separator);
                    // Add other labels



                }



                /////////////////////////////////////



                JThinButton.JThinButton deletee = new JThinButton.JThinButton();
                deletee.BackColor = System.Drawing.Color.Blue;
                deletee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                deletee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.BorderRadius = 5;
                deletee.ButtonText = "see more";
                deletee.Font = new System.Drawing.Font("Montserrat ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                deletee.Font_Size = new System.Drawing.Font("Montserrat ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                deletee.ForeColors = System.Drawing.Color.Blue;
                deletee.HoverBackground = System.Drawing.Color.Blue;
                deletee.HoverBorder = System.Drawing.Color.White; ;
                deletee.HoverFontColor = System.Drawing.Color.White;
                deletee.LineThickness = 2;
                deletee.Location = new System.Drawing.Point(600, +z + 250);
                deletee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                deletee.Size = new System.Drawing.Size(262, 51);
                deletee.TabIndex = 27;
                deletee.Click += (sender, EventArgs) => { buttonNext_Clickseemore(sender, EventArgs); };

                this.Controls.Add(deletee);

                Label labele3 = new Label();
                labele3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                labele3.Cursor = System.Windows.Forms.Cursors.Default;
                labele3.Location = new System.Drawing.Point(x, z + 400);
                labele3.Size = new System.Drawing.Size(1564, 2);
                labele3.TabIndex = 29;
                this.Controls.Add(labele3);
                /////////////////////////////////////





            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();


        }















        public learninga()
        {
            // InitializeComponent();
            InitializeComponent();
            String connec = "Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connec);
            conn.Open();

            try
            {

                int x = 20;
                int z = 60;
               // 54, 317

             //   SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
               // conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT top 8 *  FROM EVENEMENT where event_approve='true' order by id_ev desc", conn);
                SDA.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    // z += pic1.Height + 50; 315, 159




                    /// to get the event id 

                    Label id = new Label();
                    id.Text = dr["id_ev"].ToString();



                    // pcture box and its propeties
                    PictureBox pic1 = new PictureBox();
                    pic1.Width = 350;
                    pic1.Height = 126;
                    if (x > 1500)
                    {
                      //  z += pic1.Height;
                        x = 20;
                        z += pic1.Height + 150;
                        //  z = 1000;

                    }
                    pic1.ImageLocation = dr["imglocation"].ToString();
                    
                    pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic1.Location = new Point(x, z);
                   // pic1.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, pic1.ImageLocation, id.Text); };

                    //Column 1
                    Label date = new Label();
                    date.Text = dr["startDate"].ToString();
                    date.Location = new Point(x,pic1.Height+z);
                    date.AutoSize = true;
                    date.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(20)))));
                    date.Size = new System.Drawing.Size(106, 22);
                    date.TabIndex = 24;


                    //end date
                    Label datef = new Label();
                    datef.Text = dr["endDate"].ToString();
                    datef.Location = new Point(x, pic1.Height + z);
                    datef.AutoSize = true;
                    datef.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    datef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(20)))));
                    datef.Size = new System.Drawing.Size(106, 22);
                    datef.TabIndex = 24;

                    // Column 2
                    Label title = new Label();
                    title.Text = dr["nom_Ev"].ToString();
                    title.Location = new Point(x, pic1.Height + z + 30);
                    title.AutoSize = true;
                    title.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    title.ForeColor = System.Drawing.Color.Black;
                    title.Size = new System.Drawing.Size(435, 44);
                    title.TabIndex = 23;

                    // description
                    Label desc = new Label();
                    desc.Text = dr["description"].ToString();
                    desc.Location = new Point(x, pic1.Height + z + 30);
                    desc.AutoSize = true;
                    desc.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    desc.ForeColor = System.Drawing.Color.Black;
                    desc.Size = new System.Drawing.Size(435, 44);
                    desc.TabIndex = 23;


                    // city id
                    Label cityid = new Label();
                    cityid.Text = dr["id_localisation"].ToString();
                    cityid.Location = new Point(x, pic1.Height + z + 30);
                    cityid.AutoSize = true;
                    
                    /* get localisatin detaills */
                    // SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
              //  mycon.Open();
                DataSet dats = new DataSet();
                    int idloc;
                    Int32.TryParse(cityid.Text, out idloc);
                SqlDataAdapter SaDA = new SqlDataAdapter("SELECT *  FROM Localisation where id_city="+ idloc , conn);
                SaDA.Fill(dats);

                    String Cityname = "";
                    String Address = "";
                    String Codepos = "";
                    foreach (DataRow d in dats.Tables[0].Rows)
                    { 
                    Cityname = d["city"].ToString();
                    Address= d["adress"].ToString();
                    Codepos = d["codepostal"].ToString();
                    }





                        // like button

                        JThinButton.JThinButton love = new JThinButton.JThinButton();
                    love.Size = new System.Drawing.Size(32, 24);
                    // love.Location();
                    love.BackColor = System.Drawing.Color.Transparent;
                    love.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
                    love.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));

                    love.Location = new System.Drawing.Point(x+pic1.Width-20, pic1.Height + z + 35);

                    // Column 3
                    
                    Label author = new Label();
                    author.Text = dr["organisateur"].ToString();
                    author.Location = new Point(x, pic1.Height + z + 60);
                    author.AutoSize = true;
                    author.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    author.ForeColor = System.Drawing.Color.Gray;
                    author.Size = new System.Drawing.Size(103, 16);
                    author.TabIndex = 25;


                    // Column 4
                    DataSet datse = new DataSet();
                    int idev = 0;
                    Int32.TryParse(id.Text, out idev);
                    SqlDataAdapter SaDAa = new SqlDataAdapter("SELECT *  FROM TICKETSTOCK where id_evticket=" + idev, conn);
                    SaDAa.Fill(datse);


                    String prixx = "0";

                    foreach (DataRow db in datse.Tables[0].Rows)
                    {
                        prixx = db["Prix_ticket"].ToString();

                    }
                    Label price = new Label();
                    price.Location = new Point(x, pic1.Height + z + 90);
                    price.AutoSize = true;
                    price.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    price.ForeColor = System.Drawing.Color.Gray;
                    price.Size = new System.Drawing.Size(88, 16);
                    price.TabIndex = 26;
                    price.Text = prixx ;

                    //Button
                    JThinButton.JThinButton delete = new JThinButton.JThinButton();
                    delete.BackColor = System.Drawing.Color.Transparent;
                    delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
                    delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
                    delete.BorderRadius = 5;
                    delete.ButtonText = "Remove";
                    delete.Font = new System.Drawing.Font("Montserrat ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    delete.Font_Size = new System.Drawing.Font("Montserrat ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    delete.ForeColors = System.Drawing.Color.White;
                    delete.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
                    delete.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
                    delete.HoverFontColor = System.Drawing.Color.White;
                    delete.LineThickness = 2;
                    delete.Location = new System.Drawing.Point(x, pic1.Height + z + 35);
                    delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                    delete.Size = new System.Drawing.Size(262, 51);
                    delete.TabIndex = 27;
                  //  delete.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, id.Text); };
                    // delete.Click += delete_Click;

                    //Separator
                    Label label3 = new Label();
                    label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    label3.Cursor = System.Windows.Forms.Cursors.Default;
                    label3.Location = new System.Drawing.Point(pic1.Width+100,z);
                    label3.Size = new System.Drawing.Size(2, 210);
                    label3.TabIndex = 29;




                    pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic1.Location = new Point(x, z);
                    pic1.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, pic1.ImageLocation, id.Text,date.Text.ToString(),datef.Text.ToString(),title.Text.ToString(),author.Text.ToString(),price.Text.ToString(),desc.Text.ToString(),Cityname.ToString(),Address.ToString(),Codepos.ToString()); };

                    x += pic1.Width + 50;
                    this.Controls.Add(pic1);
                    this.Controls.Add(date);
                    this.Controls.Add(title);



                }



                /////////////////////////////////////



                JThinButton.JThinButton deletee = new JThinButton.JThinButton();
                deletee.BackColor = System.Drawing.Color.Blue;
                deletee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                deletee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.BorderRadius = 5;
                deletee.ButtonText = "see more";
                deletee.Font = new System.Drawing.Font("Montserrat ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                deletee.Font_Size = new System.Drawing.Font("Montserrat ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                deletee.ForeColors = System.Drawing.Color.Blue;
                deletee.HoverBackground = System.Drawing.Color.Blue; 
                deletee.HoverBorder = System.Drawing.Color.White; ;
                deletee.HoverFontColor = System.Drawing.Color.White;
                deletee.LineThickness = 2;
                deletee.Location = new System.Drawing.Point(600, + z + 250);
                deletee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                deletee.Size = new System.Drawing.Size(262, 51);
                deletee.TabIndex = 27;
                deletee.Click += (sender, EventArgs) => { buttonNext_Clickseemore(sender, EventArgs); };

                this.Controls.Add(deletee);

                Label labele3 = new Label();
                labele3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                labele3.Cursor = System.Windows.Forms.Cursors.Default;
                labele3.Location = new System.Drawing.Point(x, z + 400);
                labele3.Size = new System.Drawing.Size(1564, 2);
                labele3.TabIndex = 29;
                this.Controls.Add(labele3);
                /////////////////////////////////////





            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }



           
        }


        private void buttonNext_Click(object sender, EventArgs eventArgs, object nextTabIndex,String identi,String dtd, String dtf,String nomev,String auth,String  prc,String description,String ct,String Addr,String cod )
        {

            clickEvent cl = new clickEvent(nextTabIndex.ToString(),identi.ToString(),dtd,dtf,nomev,auth,prc,description,ct,Addr,cod);
            MainControlClass.showControl(cl, this);
        }


        private void buttonNext_Clickseemore(object sender, EventArgs eventArgs)
        {
            String query = " select *  FROM EVENEMENT where event_approve='true' order by id_ev desc";
            learninga nm = new learninga(query);

            MainControlClass.showControl(nm, this);
            
        }





        private void learninga_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clickEvent cl = new clickEvent();
            MainControlClass.showControl(cl, this);
        }

        private void locatLabel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {
           // locatLabel.Text = bunifuDropdown3.selectedValue.ToString();
        }
    }
}
