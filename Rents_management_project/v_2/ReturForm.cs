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
    public partial class ReturForm : Form
    {
        string connString;
        public ReturForm()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Clienti.accdb";
            
            
        }

        private void ReturForm_Load(object sender, EventArgs e)
        {

        }

        private void stergereLaReturnare()
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
                conexiune.Close();
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbId.AppendText(listView1.SelectedItems[0].SubItems[0].Text);
            cbMovie.Items.Add(listView1.SelectedItems[0].SubItems[1].Text);
            cbClient.Items.Add(listView1.SelectedItems[0].SubItems[2].Text);
            tbReturn.Value = DateTime.Parse(listView1.SelectedItems[0].SubItems[3].Text);
            DateTime d1 = tbReturn.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int zile = Convert.ToInt32(t.TotalDays);
            if (zile <= 0)
            {
                tbDelay.Text = "No delay";
                tbSanctiune.Text = "No fine";
            }
            else
            {
                tbDelay.Text = "" + zile;
                tbSanctiune.Text = "" + (zile * 10);
            }
        }

        private void tbAdauga_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();

                comanda.Connection = conexiune;
                comanda.CommandText = "UPDATE filme SET disponibilitate='" + "Disponibil" + "' WHERE denumire = '" + cbMovie.Text + "';"; ;
                comanda.ExecuteNonQuery();


                //comanda.Connection = conexiune;
                //comanda.CommandText = "SELECT MAX(id_retur) FROM retur";
                //int cod = Convert.ToInt32(comanda.ExecuteScalar());

                comanda.CommandText = "INSERT INTO retur VALUES (?,?,?,?,?,?)";
                comanda.Parameters.Add("id_retur", OleDbType.Integer).Value = Convert.ToInt32(tbId.Text);
                comanda.Parameters.Add("denumire", OleDbType.Char, 50).Value = cbMovie.Text;
                comanda.Parameters.Add("nume", OleDbType.Char, 50).Value = cbClient.Text;
                comanda.Parameters.Add("data_retur", OleDbType.Date).Value = Convert.ToDateTime(tbReturn.Text);
                comanda.Parameters.Add("intarziere", OleDbType.Char, 50).Value = tbDelay.Text;
                comanda.Parameters.Add("sanctiune", OleDbType.Char, 50).Value = tbSanctiune.Text;
                comanda.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                stergereLaReturnare();
                conexiune.Close();
                tbId.Clear();
                cbMovie.Text = " ";
                cbClient.Text = " ";
                tbDelay.Clear();
                tbSanctiune.Clear();

            }
        }

        private void tbVizualizare_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM retur";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["id_retur"].ToString());
                    itm.SubItems.Add(reader["denumire"].ToString());
                    itm.SubItems.Add(reader["nume"].ToString());
                    itm.SubItems.Add(reader["data_retur"].ToString());
                    itm.SubItems.Add(reader["intarziere"].ToString());
                    itm.SubItems.Add(reader["sanctiune"].ToString());
                    listView2.Items.Add(itm);

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

        private void tbUpdate_Click(object sender, EventArgs e)
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

        private void tbSalvare_Click(object sender, EventArgs e)
        {

            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM retur",
                conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "retur");

            DataTable tabela = ds.Tables["retur"];

            StreamWriter sw = new StreamWriter("Retur.txt");

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
