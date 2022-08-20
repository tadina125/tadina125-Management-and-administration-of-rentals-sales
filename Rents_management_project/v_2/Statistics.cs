using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
namespace v_2
{
    public partial class Statistics : Form
    {
        double[] vect = new double[100];
        int nr_elemente = 0;
        bool di = false;

        int margine = 10;

        public Statistics()
        {
            InitializeComponent();
        }


       
        private void Statistics_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void tbUpload_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                try
                {
                    vect[nr_elemente] = Convert.ToDouble(linie);
                    nr_elemente++;
                    di = true;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            //Invalidate();
            panel3.Invalidate();
        }

        private void tbAdauga_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void save(Control c, string denumire)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y, c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(denumire);
            img.Dispose();
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            // save(this, "poza.bmp");
            save(panel3, "poza1.bmp");
 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

            if (di == true)
            {
                Graphics g = e.Graphics;
                Rectangle rec = new Rectangle(panel3.ClientRectangle.X + margine, panel3.ClientRectangle.Y + 5 * margine, panel3.ClientRectangle.Width - 2 * margine, panel3.ClientRectangle.Height - 6 * margine);
                Pen pen = new Pen(Color.Blue, 1);
                //g.DrawRectangle(pen, rec);

                double latime = rec.Width / nr_elemente / 3;
                double distanta = (rec.Width - nr_elemente * latime) / (nr_elemente + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(Color.Black);
                Rectangle[] recs = new Rectangle[nr_elemente];


                for (int i = 0; i < nr_elemente; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rec.Height));
                    //g.DrawString(vect[i].ToString(), this.Font, br, new Point((int)(recs[i].Location.X + latime/2),(int)( recs[i].Location.Y - this.Font.Height)));

                }
                // g.FillRectangles(br, recs);

                for (int i = 0; i < nr_elemente - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2),
                        (int)(recs[i + 1].Location.Y)));
                }
            }
        }

        private void Printdocument(object sender, PrintPageEventArgs e)
        {

            if (di == true)
            {
                Graphics g = e.Graphics;
                Rectangle rec = new Rectangle(e.PageBounds.X + margine, e.PageBounds.Y + 5 * margine, e.PageBounds.Width - 2 * margine, e.PageBounds.Height - 6 * margine);
                Pen pen = new Pen(Color.Violet, 2);
                //g.DrawRectangle(pen, rec);

                double latime = rec.Width / nr_elemente / 3;
                double distanta = (rec.Width - nr_elemente * latime) / (nr_elemente + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(Color.Black);
                Rectangle[] recs = new Rectangle[nr_elemente];


                for (int i = 0; i < nr_elemente; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rec.Height));
                    //g.DrawString(vect[i].ToString(), this.Font, br, new Point((int)(recs[i].Location.X + latime/2),(int)( recs[i].Location.Y - this.Font.Height)));

                }
                // g.FillRectangles(br, recs);

                for (int i = 0; i < nr_elemente - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2),
                        (int)(recs[i + 1].Location.Y)));
                }
            }
        }
        private void tbpreview_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(Printdocument);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = doc;
            dlg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
