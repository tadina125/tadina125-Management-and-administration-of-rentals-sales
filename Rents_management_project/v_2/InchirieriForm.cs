using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace v_2
{
    public partial class InchirieriForm : Form
    {
        string connString;
        public InchirieriForm()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Clienti.accdb";
            fillMovie();
            fillCustomer();
            //update_disp();
        }

        private void fillMovie()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            conexiune.Open();
            string comanda = "SELECT denumire FROM filme WHERE disponibilitate='"+ "Disponibil" + "'";
            OleDbCommand cmd = new OleDbCommand(comanda, conexiune);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("denumire", typeof(string));
            table.Load(reader);
            cbFilm.ValueMember = "denumire";
            cbFilm.DataSource = table;
            conexiune.Close();
            cbFilm.Text = " ";
            
        }

        private void fillCustomer()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            conexiune.Open();
            string comanda = "SELECT nume FROM clienti";
            OleDbCommand cmd = new OleDbCommand(comanda, conexiune);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("nume", typeof(string));
            table.Load(reader);
            cbCustomer.ValueMember = "nume";
            cbCustomer.DataSource = table;
            conexiune.Close();
            cbCustomer.Text = " ";

        }
        private void setdisponibil()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();

            try
            {
                conexiune.Open();


                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        string denumire = itm.SubItems[1].Text;
                        //int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.Connection = conexiune;
                        comanda.CommandText = "UPDATE filme SET disponibilitate='" + "Disponibil" + "' WHERE denumire = '" + denumire + "';"; ;
                        comanda.ExecuteNonQuery();

                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                conexiune.Close();
            }
        }
        


        private void InchirieriForm_Load(object sender, EventArgs e)
        {

        }

        private void cbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tbAdauga_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                

                comanda.Connection = conexiune;
                comanda.CommandText = "UPDATE filme SET disponibilitate='" + "Indisponibil" + "' WHERE denumire = '" + cbFilm.SelectedValue.ToString() + "';"; ;
                comanda.ExecuteNonQuery();


                

                comanda.CommandText = "INSERT INTO inchiriere VALUES (?,?,?,?,?,?)";
                comanda.Parameters.Add("id_inchiriere", OleDbType.Integer).Value =  Convert.ToInt32(tbID.Text)/*cod + 1*/;
                comanda.Parameters.Add("denumire", OleDbType.Char, 50).Value = cbFilm.Text;
                comanda.Parameters.Add("nume", OleDbType.Char, 50).Value = cbCustomer.Text;
                comanda.Parameters.Add("data_inchiriere", OleDbType.Date).Value = Convert.ToDateTime(tbRental.Text);
                comanda.Parameters.Add("data_retur", OleDbType.Date).Value = Convert.ToDateTime(tbRetur.Text);
                comanda.Parameters.Add("taxa_inchiriere", OleDbType.Integer).Value = Convert.ToInt32(tbFees.Text);
                comanda.ExecuteNonQuery();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                cbFilm .Text =" ";
                cbCustomer.Text = " ";
                tbFees.Clear();
                
            }
        }

        private void tbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbVizualizare_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM inchiriere";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["id_inchiriere"].ToString());
                    itm.SubItems.Add(reader["denumire"].ToString());
                    itm.SubItems.Add(reader["nume"].ToString());
                    itm.SubItems.Add(reader["data_inchiriere"].ToString());
                    itm.SubItems.Add(reader["data_retur"].ToString());
                    itm.SubItems.Add(reader["taxa_inchiriere"].ToString());
                    listView1.Items.Add(itm);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void tbStergere_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            
            try
            {
                conexiune.Open();

               
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        //string denumire = itm.SubItems[1].Text;
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.Connection = conexiune;
                        comanda.CommandText = "DELETE FROM inchiriere WHERE id_inchiriere = " + cod;
                        comanda.ExecuteNonQuery();

                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                setdisponibil();
                conexiune.Close();
            }
            tbVizualizare_Click(sender, e);
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.Connection = conexiune;
                        comanda.CommandText = "DELETE FROM inchiriere WHERE id_inchiriere = " + cod;
                        comanda.ExecuteNonQuery();

                        
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                setdisponibil();
                conexiune.Close();
            }
            tbVizualizare_Click(sender, e);
        }

        private void tbUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.Connection = conexiune;
                        comanda.CommandText = "UPDATE inchiriere SET data_retur='" + tbRetur.Text + "' WHERE id_inchiriere= " + cod;
                        comanda.ExecuteNonQuery();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
            tbVizualizare_Click(sender, e);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbSalvare_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM inchiriere",
                conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "inchiriere");

            DataTable tabela = ds.Tables["inchiriere"];

            StreamWriter sw = new StreamWriter("Inchirieri.txt");

            foreach (DataRow row in ds.Tables[0].Rows)
            {


                foreach (object item in row.ItemArray)
                {

                    sw.Write(item.ToString() + "\t");

                }
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Date salvate!");
        }
    }
}
