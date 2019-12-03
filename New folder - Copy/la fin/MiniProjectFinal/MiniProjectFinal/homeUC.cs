using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace MiniProjectFinal
{
    public partial class homeUC : UserControl
    {
        private String email;
        private String password;
        private String ana;
        
        public homeUC(String Q,String em, String pass)
        {
            string connections = "Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connections);
            conn.Open();

            InitializeComponent();
            locatLabel.Text = bunifuDropdown3.selectedValue.ToString();
            
            
            DataSet dSSs = new DataSet();
            SqlDataAdapter SDSA = new SqlDataAdapter("SELECT * FROM EVENEMENT WHERE (DATEDIFF(DAY,endDate,GETDATE()) < 3)", conn);
            SDSA.Fill(dSSs);

            foreach (DataRow drh in dSSs.Tables[0].Rows)
            {
                label6.Text += "L'evenement " + drh["nom_Ev"] + " va se terminer aprés 3 jours !" + " || ";
            }

             DataSet dSTs = new DataSet();
            SqlDataAdapter STSA = new SqlDataAdapter("SELECT * FROM EVENEMENT WHERE id_ev IN (SELECT id_evticket FROM TICKETSTOCK WHERE t_available < 10)", conn);
            STSA.Fill(dSTs);

            foreach (DataRow drh in dSTs.Tables[0].Rows)
            {
                label6.Text += "On a moins que 10 tickets valables pour l''evenement " + drh["nom_Ev"] + " || ";
            }

            this.email = em;
            this.password = pass;


            try
            {
                String UUUUSSR;

                SqlDataAdapter SAee = new SqlDataAdapter("SELECT * FROM EV_USER where email='"+this.email+"' and password='"+this.password+"' ", conn);
                DataSet datsse = new DataSet();
                SAee.Fill(datsse);
                foreach (DataRow dr in datsse.Tables[0].Rows)
                { 
                UUUUSSR = dr["id_user"].ToString();
                    this.ana = UUUUSSR;
                }
                
                    int x = 35;
                int z = 317;

                DataSet ds = new DataSet();
                SqlDataAdapter SDA = new SqlDataAdapter(Q, conn);
                SDA.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {

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
                        x = 35;
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
                    if(dr["nom_Ev"].ToString().Length > 36)
                    datef.Text = (dr["nom_Ev"].ToString()).Substring(0, 36) + "...";
                    else
                        datef.Text = dr["nom_Ev"].ToString();
                    datef.Location = new Point(x, pic1.Height + z);
                    datef.AutoSize = true;
                    datef.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    datef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(69)))), ((int)(((byte)(20)))));
                    datef.Size = new System.Drawing.Size(106, 22);
                    datef.TabIndex = 24;

                    // Column 2
                    Label title = new Label();
                    if (dr["nom_Ev"].ToString().Length > 36)
                        title.Text = (dr["nom_Ev"].ToString()).Substring(0, 36);
                    else
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

                    DataSet dats = new DataSet();
                    int idloc;
                    Int32.TryParse(cityid.Text, out idloc);
                    SqlDataAdapter SaDA = new SqlDataAdapter("SELECT *  FROM Localisation where id_city=" + idloc, conn);
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
                   // mycon.Close();
                    // like button

                    // like button
                    Button love = new Button();
                    love.FlatAppearance.BorderSize = 0;
                    love.FlatAppearance.BorderColor = System.Drawing.Color.White;
                    love.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
                    love.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
                    love.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    love.Size = new System.Drawing.Size(32, 24);
                    love.TabIndex = 7;
                    love.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                    love.UseVisualStyleBackColor = true;


                    SqlDataAdapter SAe = new SqlDataAdapter("SELECT *  FROM LIKES ", conn);
                    DataSet datss = new DataSet();
                    SAe.Fill(datss);
                    if (datss.Tables[0].Rows.Count == 0)
                    {

                        // like button


                        love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\like.png");
                        // love.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\final one\heart");

                    }
                    else
                    {
                        string usr;
                        string ev;
                        Boolean gd = false;
                        foreach (DataRow dLIK in datss.Tables[0].Rows)
                        {
                            usr = dLIK["userID"].ToString();
                            ev = dLIK["eventID"].ToString();




                            if (usr == this.ana && ev == id.Text.ToString())
                            {
                                love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\likes.png");
                                gd = true;
                                break;
                            }
                            //else
                            if (!gd)
                            {
                                love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\like.png");
                            }


                        }
                    }
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
                  //  myecon.Close();
                    Label price = new Label();
                    price.Location = new Point(x, pic1.Height + z + 90);
                    price.AutoSize = true;
                    price.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    price.ForeColor = System.Drawing.Color.Gray;
                    price.Size = new System.Drawing.Size(88, 16);
                    price.TabIndex = 26;
                    price.Text = prixx;

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



                    pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic1.Location = new Point(x, z);
                    pic1.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, pic1.ImageLocation, id.Text, date.Text.ToString(), datef.Text.ToString(), title.Text.ToString(), author.Text.ToString(), price.Text.ToString(), desc.Text.ToString(), Cityname.ToString(), Address.ToString(), Codepos.ToString(),this.email,this.password); };
                    love.Click += (sender, EventArgs) => { love_Click(sender, EventArgs, pic1.ImageLocation, id.Text, date.Text.ToString(), datef.Text.ToString(), title.Text.ToString(), author.Text.ToString(), price.Text.ToString(), desc.Text.ToString(), Cityname.ToString(), Address.ToString(), Codepos.ToString(),this.email,this.password); };

                    x += pic1.Width + 50;
                    this.Controls.Add(pic1);
                    this.Controls.Add(date);
                    this.Controls.Add(title);

                    this.Controls.Add(love);



                }



                /////////////////////////////////////



                JThinButton.JThinButton deletee = new JThinButton.JThinButton();

                deletee.BackColor = System.Drawing.Color.Transparent;
                deletee.BackgroundColor = System.Drawing.Color.White;
                deletee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.BorderRadius = 5;
                deletee.ButtonText = "See More";
                deletee.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                deletee.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                deletee.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.HoverBackground = System.Drawing.Color.White;
                deletee.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.HoverFontColor = System.Drawing.SystemColors.Highlight;
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







        public homeUC(String em,String pass)
        {

            string connectionstring = "Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
            SqlConnection conection = new SqlConnection(connectionstring);
            conection.Open();

            InitializeComponent();
            locatLabel.Text = bunifuDropdown3.selectedValue.ToString();
            locatLabel.Text = bunifuDropdown3.selectedValue.ToString();

            DataSet dSSs = new DataSet();
            SqlDataAdapter SDSA = new SqlDataAdapter("SELECT * FROM EVENEMENT WHERE (DATEDIFF(DAY,endDate,GETDATE()) < 3)", conection);
            SDSA.Fill(dSSs);

            foreach (DataRow drh in dSSs.Tables[0].Rows)
            {
                label6.Text += "L'evenement " + drh["nom_Ev"] + " va se terminer aprés 3 jours !" + " || ";
            }

            DataSet dSTs = new DataSet();
            SqlDataAdapter STSA = new SqlDataAdapter("SELECT * FROM EVENEMENT WHERE id_ev IN (SELECT id_evticket FROM TICKETSTOCK WHERE t_available < 10)", conection);
            STSA.Fill(dSTs);

            foreach (DataRow drh in dSTs.Tables[0].Rows)
            {
                label6.Text += "On a moins que 10 tickets valables pour l''evenement " + drh["nom_Ev"] + " || ";
            }
           // cCMonn.Close();
            this.email = em;
            this.password = pass;
 

            try
            {
                String UUUUSSR;

                SqlDataAdapter SAee = new SqlDataAdapter("SELECT * FROM EV_USER where email='" + this.email + "' and password='" + this.password + "' ", conection);
                DataSet datsse = new DataSet();
                SAee.Fill(datsse);
                foreach (DataRow dr in datsse.Tables[0].Rows)
                {
                    UUUUSSR = dr["id_user"].ToString();
                    this.ana = UUUUSSR;
                }

              //  myeconce.Close();

                int x = 54;
                int z = 317;

                DataSet ds = new DataSet();
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT top 8 *  FROM EVENEMENT where event_approve='true' order by id_ev asc ", conection);
                SDA.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {


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
                        x = 54;
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

                    DataSet dats = new DataSet();
                    int idloc;
                    Int32.TryParse(cityid.Text, out idloc);
                    SqlDataAdapter SaDA = new SqlDataAdapter("SELECT *  FROM Localisation where id_city=" + idloc, conection);
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

                    // like button
                    Button love = new Button();
                    love.FlatAppearance.BorderSize = 0;
                    love.FlatAppearance.BorderColor = System.Drawing.Color.White;
                    love.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
                    love.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
                    love.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    love.Size = new System.Drawing.Size(32, 24);
                    love.TabIndex = 7;
                    love.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                    love.UseVisualStyleBackColor = true;

                    SqlDataAdapter SAe = new SqlDataAdapter("SELECT *  FROM LIKES ", conection);
                    DataSet datss = new DataSet();
                    SAe.Fill(datss);
                    if (datss.Tables[0].Rows.Count == 0)
                    {

                        // like button


                        love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\like.png");
                        // love.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\final one\heart");

                    }
                    else
                    {
                        string usr;
                        string ev;
                        Boolean gd = false;
                        foreach (DataRow dLIK in datss.Tables[0].Rows)
                        {
                            usr = dLIK["userID"].ToString();
                            ev = dLIK["eventID"].ToString();
                            



                            if (usr == this.ana && ev == id.Text.ToString())
                            {
                                love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\likes.png");
                                gd = true;
                                break;
                            }
                            //else
                            if(!gd)
                            {
                                love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\like.png");
                            }


                        }
                    }
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
                  //  SqlConnection myecon = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                 //   myecon.Open();
                    DataSet datse = new DataSet();
                    int idev = 0;
                    Int32.TryParse(id.Text, out idev);
                    SqlDataAdapter SaDAa = new SqlDataAdapter("SELECT *  FROM TICKETSTOCK where id_evticket=" + idev, conection);
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
                    price.Text = prixx;

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



                    pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic1.Location = new Point(x, z);
                    pic1.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, pic1.ImageLocation, id.Text, date.Text.ToString(), datef.Text.ToString(), title.Text.ToString(), author.Text.ToString(), price.Text.ToString(), desc.Text.ToString(), Cityname.ToString(), Address.ToString(), Codepos.ToString(), this.email, this.password); };
                    love.Click += (sender, EventArgs) => { love_Click(sender, EventArgs, pic1.ImageLocation, id.Text, date.Text.ToString(), datef.Text.ToString(), title.Text.ToString(), author.Text.ToString(), price.Text.ToString(), desc.Text.ToString(), Cityname.ToString(), Address.ToString(), Codepos.ToString(), this.email, this.password); };

                    x += pic1.Width + 50;
                    this.Controls.Add(pic1);
                    this.Controls.Add(date);
                    this.Controls.Add(title);

                    this.Controls.Add(love);



                }



                /////////////////////////////////////



                JThinButton.JThinButton deletee = new JThinButton.JThinButton();
                deletee.BackColor = System.Drawing.Color.Transparent;
                deletee.BackgroundColor = System.Drawing.Color.White;
                deletee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.BorderRadius = 5;
                deletee.ButtonText = "See More";
                deletee.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                deletee.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                deletee.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.HoverBackground = System.Drawing.Color.White;
                deletee.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.HoverFontColor = System.Drawing.SystemColors.Highlight;
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

            conection.Close();
        }



        public homeUC(String Q)
        {

            string connectionstring = "Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
            SqlConnection conection = new SqlConnection(connectionstring);
            conection.Open();

            InitializeComponent();
            locatLabel.Text = bunifuDropdown3.selectedValue.ToString();
            locatLabel.Text = bunifuDropdown3.selectedValue.ToString();

            DataSet dSSs = new DataSet();
            SqlDataAdapter SDSA = new SqlDataAdapter("SELECT * FROM EVENEMENT WHERE (DATEDIFF(DAY,endDate,GETDATE()) < 3)", conection);
            SDSA.Fill(dSSs);

            foreach (DataRow drh in dSSs.Tables[0].Rows)
            {
                label6.Text += "L'evenement " + drh["nom_Ev"] + " va se terminer aprés 3 jours !" + " || ";
            }

            DataSet dSTs = new DataSet();
            SqlDataAdapter STSA = new SqlDataAdapter("SELECT * FROM EVENEMENT WHERE id_ev IN (SELECT id_evticket FROM TICKETSTOCK WHERE t_available < 10)", conection);
            STSA.Fill(dSTs);

            foreach (DataRow drh in dSTs.Tables[0].Rows)
            {
                label6.Text += "On a moins que 10 tickets valables pour l''evenement " + drh["nom_Ev"] + " || ";
            }


            try
            {

                String UUUUSSR;

                SqlDataAdapter SAee = new SqlDataAdapter("SELECT * FROM EV_USER where email='" + this.email + "' and password='" + this.password + "' ", conection);
                DataSet datsse = new DataSet();
                SAee.Fill(datsse);
                foreach (DataRow dr in datsse.Tables[0].Rows)
                {
                    UUUUSSR = dr["id_user"].ToString();
                    this.ana = UUUUSSR;
                }
               // myeconce.Close();
                int x = 54;
                int z = 317;
                // 54, 317

                DataSet ds = new DataSet();
                SqlDataAdapter SDA = new SqlDataAdapter(Q, conection);
                SDA.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {


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
                        x = 54;
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

                    DataSet dats = new DataSet();
                    int idloc;
                    Int32.TryParse(cityid.Text, out idloc);
                    SqlDataAdapter SaDA = new SqlDataAdapter("SELECT *  FROM Localisation where id_city=" + idloc, conection);
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
                    Button love = new Button();
                    love.FlatAppearance.BorderSize = 0;
                    love.FlatAppearance.BorderColor = System.Drawing.Color.White;
                    love.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
                    love.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
                    love.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    love.Size = new System.Drawing.Size(32, 24);
                    love.TabIndex = 7;
                    love.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                    love.UseVisualStyleBackColor = true;

                    SqlDataAdapter SAe = new SqlDataAdapter("SELECT *  FROM LIKES ", conection);
                    DataSet datss = new DataSet();
                    SAe.Fill(datss);
                    if (datss.Tables[0].Rows.Count == 0)
                    {

                        // like button


                        love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\like.png");
                        // love.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\final one\heart");

                    }
                    else
                    {
                        string usr;
                        string ev;
                        Boolean gd = false;
                        foreach (DataRow dLIK in datss.Tables[0].Rows)
                        {
                            usr = dLIK["userID"].ToString();
                            ev = dLIK["eventID"].ToString();




                            if (usr == this.ana && ev == id.Text.ToString())
                            {
                                love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\likes.png");
                                gd = true;
                                break;
                            }
                            //else
                            if (!gd)
                            {
                                love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\like.png");
                            }


                        }
                    }
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

                    DataSet datse = new DataSet();
                    int idev = 0;
                    Int32.TryParse(id.Text, out idev);
                    SqlDataAdapter SaDAa = new SqlDataAdapter("SELECT *  FROM TICKETSTOCK where id_evticket=" + idev, conection);
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
                    price.Text = prixx;

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


                    pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic1.Location = new Point(x, z);
                    pic1.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, pic1.ImageLocation, id.Text, date.Text.ToString(), datef.Text.ToString(), title.Text.ToString(), author.Text.ToString(), price.Text.ToString(), desc.Text.ToString(), Cityname.ToString(), Address.ToString(), Codepos.ToString(), this.email, this.password); };
                    love.Click += (sender, EventArgs) => { love_Click(sender, EventArgs, pic1.ImageLocation, id.Text, date.Text.ToString(), datef.Text.ToString(), title.Text.ToString(), author.Text.ToString(), price.Text.ToString(), desc.Text.ToString(), Cityname.ToString(), Address.ToString(), Codepos.ToString(), this.email, this.password); };

                    x += pic1.Width + 50;
                    this.Controls.Add(pic1);
                    this.Controls.Add(date);
                    this.Controls.Add(title);

                    this.Controls.Add(love);
                    //this.Controls.Add(separator);
                    // Add other labels



                }



                /////////////////////////////////////



                JThinButton.JThinButton deletee = new JThinButton.JThinButton();
                deletee.BackColor = System.Drawing.Color.Transparent;
                deletee.BackgroundColor = System.Drawing.Color.White;
                deletee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.BorderRadius = 5;
                deletee.ButtonText = "See More";
                deletee.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                deletee.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                deletee.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.HoverBackground = System.Drawing.Color.White;
                deletee.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.HoverFontColor = System.Drawing.SystemColors.Highlight;
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

            conection.Close();
        }


        public homeUC()
        {

            string connections = "Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
            SqlConnection conne = new SqlConnection(connections);
            conne.Open();

            InitializeComponent();
            locatLabel.Text = bunifuDropdown3.selectedValue.ToString();
            locatLabel.Text = bunifuDropdown3.selectedValue.ToString();
          //  SqlConnection cMonn = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
          //  cMonn.Open();
            DataSet dSSs = new DataSet();
            SqlDataAdapter SDSA = new SqlDataAdapter("SELECT * FROM EVENEMENT WHERE (DATEDIFF(DAY,endDate,GETDATE()) < 3)", conne);
            SDSA.Fill(dSSs);

            foreach (DataRow drh in dSSs.Tables[0].Rows)
            {
                label6.Text += "L'evenement " + drh["nom_Ev"] + " va se terminer aprés 3 jours !" + " || ";
            }

           // SqlConnection cCMonn = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
          //  cCMonn.Open();
            DataSet dSTs = new DataSet();
            SqlDataAdapter STSA = new SqlDataAdapter("SELECT * FROM EVENEMENT WHERE id_ev IN (SELECT id_evticket FROM TICKETSTOCK WHERE t_available < 10)", conne);
            STSA.Fill(dSTs);

            foreach (DataRow drh in dSTs.Tables[0].Rows)
            {
                label6.Text += "On a moins que 10 tickets valables pour l''evenement " + drh["nom_Ev"] + " || ";
            }

 

            try
            {
                String UUUUSSR;

                SqlDataAdapter SAee = new SqlDataAdapter("SELECT * FROM EV_USER where email='" + this.email + "' and password='" + this.password + "' ", conne);
                DataSet datsse = new DataSet();
                SAee.Fill(datsse);
                foreach (DataRow dr in datsse.Tables[0].Rows)
                {
                    UUUUSSR = dr["id_user"].ToString();
                    this.ana = UUUUSSR;
                }

                int x = 54;
                int z = 317;

                DataSet ds = new DataSet();
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT top 8 *  FROM EVENEMENT where event_approve='true' order by id_ev asc", conne);
                SDA.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {


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
                        x = 54;
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
                  //  SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                  //  mycon.Open();
                    DataSet dats = new DataSet();
                    int idloc;
                    Int32.TryParse(cityid.Text, out idloc);
                    SqlDataAdapter SaDA = new SqlDataAdapter("SELECT *  FROM Localisation where id_city=" + idloc, conne);
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

                    // like button
                    Button love = new Button();
                    love.FlatAppearance.BorderSize = 0;
                    love.FlatAppearance.BorderColor = System.Drawing.Color.White;
                    love.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
                    love.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
                    love.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    love.Size = new System.Drawing.Size(32, 24);
                    love.TabIndex = 7;
                    love.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                    love.UseVisualStyleBackColor = true;

                  //  SqlConnection myeconc = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                    // SqlConnection mycon = new SqlConnection("Data Source=DESKTOP-HL4O4OE;Initial Catalog=eventtest;Integrated Security=True");
                  //  myeconc.Open();
                    SqlDataAdapter SAe = new SqlDataAdapter("SELECT *  FROM LIKES ", conne);
                    DataSet datss = new DataSet();
                    SAe.Fill(datss);
                    if (datss.Tables[0].Rows.Count == 0)
                    {

                        // like button


                        love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\like.png");
                        // love.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\final one\heart");

                    }
                    else
                    {
                        string usr;
                        string ev;
                        Boolean gd = false;
                        foreach (DataRow dLIK in datss.Tables[0].Rows)
                        {
                            usr = dLIK["userID"].ToString();
                            ev = dLIK["eventID"].ToString();




                            if (usr == this.ana && ev == id.Text.ToString())
                            {
                                love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\likes.png");
                                gd = true;
                                break;
                            }
                            //else
                            if (!gd)
                            {
                                love.Image = System.Drawing.Image.FromFile(@"C:\Users\oussama ouardini\Desktop\mini project  resources\pictures\like.png");
                            }


                        }
                    }
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

                   // SqlConnection myecon = new SqlConnection("Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True");
                  //  myecon.Open();
                    DataSet datse = new DataSet();
                    int idev = 0;
                    Int32.TryParse(id.Text, out idev);
                    SqlDataAdapter SaDAa = new SqlDataAdapter("SELECT *  FROM TICKETSTOCK where id_evticket=" + idev, conne);
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
                    price.Text = prixx;

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
                    pic1.Click += (sender, EventArgs) => { buttonNext_Click(sender, EventArgs, pic1.ImageLocation, id.Text, date.Text.ToString(), datef.Text.ToString(), title.Text.ToString(), author.Text.ToString(), price.Text.ToString(), desc.Text.ToString(), Cityname.ToString(), Address.ToString(), Codepos.ToString(), this.email, this.password); };
                    love.Click += (sender, EventArgs) => { love_Click(sender, EventArgs, pic1.ImageLocation, id.Text, date.Text.ToString(), datef.Text.ToString(), title.Text.ToString(), author.Text.ToString(), price.Text.ToString(), desc.Text.ToString(), Cityname.ToString(), Address.ToString(), Codepos.ToString(), this.email, this.password); };
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
                    this.Controls.Add(love);
                    //this.Controls.Add(separator);
                    // Add other labels



                }



                /////////////////////////////////////



                JThinButton.JThinButton deletee = new JThinButton.JThinButton();
                deletee.BackColor = System.Drawing.Color.Transparent;
                deletee.BackgroundColor = System.Drawing.Color.White;
                deletee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.BorderRadius = 5;
                deletee.ButtonText = "See More";
                deletee.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                deletee.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                deletee.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.HoverBackground = System.Drawing.Color.White;
                deletee.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
                deletee.HoverFontColor = System.Drawing.SystemColors.Highlight;
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


              //  homeUC1_Load(sender, e, query, this.UserEmail, this.Userpass);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }


            conne.Close();


        }

        private void buttonNext_Click(object sender, EventArgs eventArgs, object nextTabIndex, String identi, String dtd, String dtf, String nomev, String auth, String prc, String description, String ct, String Addr, String cod, String em, String pass)
        {
            // throw new NotImplementedException();

            // int n = Int32.Parse(nextTabIndex.ToString());
            //  msgbx ms = new msgbx("Êtes-vous sûr de vouloir supprimer cet événement?", n);
            //  ms.Show();
            // MessageBox.Show(n.ToString());
            clickEvent cl = new clickEvent(nextTabIndex.ToString(), identi.ToString(), dtd, dtf, nomev, auth, prc, description, ct, Addr, cod,this.email,this.password);
            MainControlClass.showControl(cl, this);
        }

        private void love_Click(object sender, EventArgs eventArgs, object nextTabIndex, String identi, String dtd, String dtf, String nomev, String auth, String prc, String description, String ct, String Addr, String cod,String em , String pass)
        {
            String cooncs = "Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
            SqlConnection con = new SqlConnection(cooncs);
            con.Open();
            try
            {


                
                String query1 = " insert into LIKES(userId,eventId) select id_user,'"+ identi+"' from EV_USER WHERE email='"+this.email+"'   ";

                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
              //  MessageBox.Show("liked this image");
             //   con.Close();

                homeUC hm = new homeUC("SELECT * FROM EVENEMENT WHERE event_approve = 'true'",this.email,this.password);
                MainControlClass.showControl(hm, this);




            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
            con.Close();

        }



        public void buttonNext_Clickseemore(object sender, EventArgs eventArgs)
        {
            // throw new NotImplementedException();

            // int n = Int32.Parse(nextTabIndex.ToString());
            //  msgbx ms = new msgbx("Êtes-vous sûr de vouloir supprimer cet événement?", n);
            //  ms.Show();
            // MessageBox.Show(n.ToString());
            // clickEvent cl = new clickEvent();
            //  MainControlClass.showControl(cl, this);
            String ord = locatLabel.Text.ToString();
            String query = " select *  FROM EVENEMENT where event_approve='true' order by id_ev asc";
            homeUC nm = new homeUC(query,this.email,this.password);
            home h = new home();
          
           // h.homeUC1_Load(sender,eventArgs,"select *  FROM EVENEMENT where event_approve='true' order by id_ev desc",this.email,this.password);
            /*
             homeUC hm = new homeUC(this.UserEmail, this.Userpass);
            homeUC1_Load(sender, e, "SELECT top 8 * FROM EVENEMENT where  event_approve = 'true'", this.UserEmail, this.Userpass);
             */

            MainControlClass.showControl(nm, this);

        }



        public static byte[] SerializeLong2Dec(double value)
        {
            value *= 100;
            value = Math.Round(value, MidpointRounding.AwayFromZero);

            if (value < -999999999.0 || value > 999999999.0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int value2 = (int)value;

            return BitConverter.GetBytes(value2);
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }


        private void homeUC_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clickEvent cl = new clickEvent();
            MainControlClass.showControl(cl, this);

        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            // event1.ImageLocation = "C:/Users/oussama ouardini/Desktop/S3/est.jpg";
            String Conction = "Data Source=DESKTOP-7RFMD1S;Initial Catalog=eventtest;Integrated Security=True";
             /*string query = "SELECT image FROM EVENEMENT WHERE type_ev = '" +type.selectedValue.ToString()+ "'" + "AND id_ev = 314";*/
             SqlConnection con = new SqlConnection(Conction);
            con.Open();
            //SqlCommand cmd = new SqlCommand(query, con);
            //String result = (String)cmd.ExecuteScalar();

            DataTable dt = new DataTable(); 
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM EVENEMENT WHERE event_approve = 'true'and type_ev = '" + type.selectedValue.ToString() + "'", con);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;


            
            con.Close();






        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void startDate_onValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void seeMore_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void locatLabel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {
            locatLabel.Text = bunifuDropdown3.selectedValue.ToString();
        }

        private void date01_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Location = new Point(label6.Location.X + 5, label6.Location.Y);

            if (label6.Location.X > this.Width)
            {


                label6.Location = new Point(0 - label6.Width, label6.Location.Y);

            }

        }
    }
}
