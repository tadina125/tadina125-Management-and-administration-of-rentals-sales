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
    public partial class FimeForm : Form
    {
        string connString;
        public FimeForm()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Clienti.accdb";
        }

        private void FimeForm_Load(object sender, EventArgs e)
        {
           
        }
        private void tbAdauga_Click_1(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT MAX(id_film) FROM filme";
                int cod = Convert.ToInt32(comanda.ExecuteScalar());

                comanda.CommandText = "INSERT INTO filme VALUES (?,?,?,?,?,?)";
                comanda.Parameters.Add("id_film", OleDbType.Integer).Value = cod + 1;
                comanda.Parameters.Add("categorie", OleDbType.Char, 50).Value = tbCategorie.Text;
                comanda.Parameters.Add("denumire", OleDbType.Char, 50).Value = tbDenumire.Text;
                comanda.Parameters.Add("an_lansare", OleDbType.Integer).Value = Convert.ToInt32(tbAn.Text);
                comanda.Parameters.Add("pret", OleDbType.Integer).Value = Convert.ToInt32(tbPret.Text);
                comanda.Parameters.Add("disponibilitate", OleDbType.Char, 50).Value = cbDisponibilitate.Text;
                comanda.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbCategorie.Clear();
                tbDenumire.Clear();
                tbAn.Clear();
                tbPret.Clear();
                cbDisponibilitate.Text = "";

            }
        }
        private void tbVizualizare_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            try
            {
                conexiune.Open();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM filme";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["id_film"].ToString());
                    itm.SubItems.Add(reader["categorie"].ToString());
                    itm.SubItems.Add(reader["denumire"].ToString());
                    itm.SubItems.Add(reader["an_lansare"].ToString());
                    itm.SubItems.Add(reader["pret"].ToString());
                    itm.SubItems.Add(reader["disponibilitate"].ToString());
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
                        comanda.CommandText = "UPDATE filme SET disponibilitate='" + cbDisponibilitate.Text + "' WHERE id_film= " + cod;
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
            tbVizualizare_Click_1(sender, e);
        }

        private void cbDisponibilitate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbSalvare_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM filme",
                conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "filme");

            DataTable tabela = ds.Tables["filme"];

            StreamWriter sw = new StreamWriter("Filme.txt");

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
                        comanda.CommandText = "DELETE FROM filme WHERE id_film = " + cod;
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
            tbAdauga_Click_1(sender, e);
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
                        comanda.CommandText = "DELETE FROM filme WHERE id_film = " + cod;
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
            tbVizualizare_Click_1(sender, e);
        }
    }
}
