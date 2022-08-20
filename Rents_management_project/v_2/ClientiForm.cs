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
using System.Data.OleDb;

namespace v_2
{
    public partial class ClientiForm : Form
    {
        
        string connString;
        public ClientiForm()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Clienti.accdb";
        }

        private void ClientiForm_Load(object sender, EventArgs e)
        {

        }

        private void tbAdauga_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT MAX(id_client) FROM clienti";
                int cod = Convert.ToInt32(comanda.ExecuteScalar());

                comanda.CommandText = "INSERT INTO clienti VALUES (?,?,?,?,?)";
                comanda.Parameters.Add("id_client", OleDbType.Integer).Value = cod + 1;
                comanda.Parameters.Add("nume", OleDbType.Char, 20).Value = tbNume.Text;
                comanda.Parameters.Add("prenume", OleDbType.Char, 20).Value = tbPrenume.Text;
                comanda.Parameters.Add("varsta", OleDbType.Integer).Value = Convert.ToInt32(tbVarsta.Text);
                comanda.Parameters.Add("adresa", OleDbType.Char, 50).Value = tbAdresa.Text;
                comanda.ExecuteNonQuery();

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbNume.Clear();
                tbPrenume.Clear();
                tbVarsta.Clear();
                tbAdresa.Clear();
            }
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
                comanda.CommandText = "SELECT * FROM clienti";
                OleDbDataReader reader = comanda.ExecuteReader();
                while(reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["id_client"].ToString());
                    itm.SubItems.Add(reader["nume"].ToString());
                    itm.SubItems.Add(reader["prenume"].ToString());
                    itm.SubItems.Add(reader["varsta"].ToString());
                    itm.SubItems.Add(reader["adresa"].ToString());
                    listView1.Items.Add(itm);

                }
                reader.Close();
            }
            catch(Exception ex)
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
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                foreach(ListViewItem itm in listView1.Items)
                    if(itm.Checked)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.Connection = conexiune;
                        comanda.CommandText = "UPDATE clienti SET nume='" + tbNume.Text + "' WHERE id_client= " + cod;
                        comanda.ExecuteNonQuery();
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
            tbVizualizare_Click(sender, e);
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
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.Connection = conexiune;
                        comanda.CommandText = "DELETE FROM clienti WHERE id_client = " + cod;
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
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM clienti",
                conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "clienti");

            DataTable tabela = ds.Tables["clienti"];

            StreamWriter sw = new StreamWriter("Clienti.txt");

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

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
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
                        comanda.CommandText = "DELETE FROM clienti WHERE id_client = " + cod;
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

  
        
}
