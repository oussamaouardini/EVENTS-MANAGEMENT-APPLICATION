using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectFinal
{
    public partial class clickEvent : UserControl
    {
        private String location;
        private String event_id;
        private String datedeb;
        private String datefin;
        private String nameevent;
        private String organisateur;
        private String prix;
        private String description;
        private String city;
        private String address;
        private String codepostal;

        // private String event_id;
        public clickEvent()
        {
            InitializeComponent();
        }

        public clickEvent(String picloc , String id, String dtd, String dtf, String nomev, String auth, String prc,String  desc, String ct, String Addr, String cod)
        {
            InitializeComponent();
            this.location = picloc;
            this.event_id = id;
            this.datedeb = dtd;
            this.datefin = dtf;
            this.nameevent = nomev;
            this.organisateur = auth;
            this.prix = prc;
            this.description = desc;
            pictureBox1.ImageLocation = picloc;
            this.city = ct;
            this.address = Addr;
            this.codepostal = cod;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = dtd;
            label2.Text = nomev;
            label3.Text = auth;
            label5.Text = desc;
            label15.Text = ct+"  "+Addr +"   "+cod;
            label11.Text = dtd;
            label12.Text = dtf;



        }

        private void jThinButton4_Click(object sender, EventArgs e)
        {
            Tickets tk = new Tickets();
            tk.ShowDialog();
        }

        private void clickEvent_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
