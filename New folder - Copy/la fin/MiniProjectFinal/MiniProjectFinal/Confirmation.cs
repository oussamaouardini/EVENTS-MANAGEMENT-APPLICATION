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
    public partial class Confirmation : Form
    {
        public Boolean conf = false;
        private String email;
        private String passe;
        public Confirmation()
        {
            InitializeComponent();
        }
        public Confirmation(String s)
        {
            InitializeComponent();
            label1.Text = s;

        }
        public Confirmation(String s, String em, String pass)
        {
            InitializeComponent();
            label1.Text = s;
            this.email = em;
            this.passe = pass;

        }

        private void Confirmation_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.conf = true;
            home hm = new home(this.email, this.passe);
            hm.ShowDialog();
            hm.homeUC1_Load(sender, e, "SELECT top 8 * FROM EVENEMENT where  event_approve = 'true' order by id_ev asc ", this.email, this.passe);
            this.Close();
        }
    }
}
