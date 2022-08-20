using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbClienti_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientiForm  cli = new ClientiForm();
            cli.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tbFilme_Click(object sender, EventArgs e)
        {
            this.Hide();
            FimeForm film = new FimeForm();
            film.Show();
        }

        private void tbReturnari_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturForm retur = new ReturForm();
            retur.Show();
        }

        private void tbInchirieri_Click(object sender, EventArgs e)
        {
            this.Hide();
            InchirieriForm inchiriere = new InchirieriForm();
            inchiriere.Show();
        }

        private void tbLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics sts = new Statistics();
            sts.Show();
        }
    }
}
