using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE.Prog1.Albume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OleDbConnection GetConexiune()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vladimir\Documents\FEAA Cursuri\Programare1\2020\IE.Prog1\BD\GestAlbume.accdb;Persist Security Info=False;";
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Conexiunea la DB nu s-a putut realiza!");
                return null;
            }

            return conn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = GetConexiune();
            if (conn == null)
            {
                return;
            }


            OleDbCommand selectCommand = new OleDbCommand();
            selectCommand.Connection = conn;
            selectCommand.CommandText = "SELECT ID, Denumire FROM Albume";

            OleDbDataReader reader = selectCommand.ExecuteReader();

            DataTable albume = new DataTable("Albume");
            albume.Load(reader);

            uxComboBoxAlbume.DataSource = albume;

            if (!reader.IsClosed)
            {
                reader.Close();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }


        }

        private void uxComboBoxAlbume_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)uxComboBoxAlbume.SelectedValue;

            OleDbConnection conn = GetConexiune();
            if (conn == null)
            {
                return;
            }

            OleDbCommand selectByIdCommand = new OleDbCommand();
            selectByIdCommand.Connection = conn;
            selectByIdCommand.CommandText = "select * from Albume where ID=@id";
            selectByIdCommand.Parameters.AddWithValue("id", id);

            OleDbDataReader reader = selectByIdCommand.ExecuteReader();

            reader.Read();

            uxTextBoxInv.Text = reader["ID"].ToString();
            uxDateTimePickerData.Value = (DateTime)reader["Data"];
            uxTextBoxArtist.Text = reader["Artist"].ToString();
            uxTextBoxDenumire.Text = reader["Denumire"].ToString();
            uxTextBoxPret.Text = reader["Pret"].ToString();
            uxComboBoxSuport.SelectedItem = reader["Suport"].ToString();

            if (!reader.IsClosed)
            {
                reader.Close();
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }

        private void uxButtonNou_Click(object sender, EventArgs e)
        {
            uxTextBoxInv.Text = "-1";
            uxTextBoxDenumire.Text = "";
            uxTextBoxArtist.Text = string.Empty;
            uxTextBoxPret.Text = "0";
            uxDateTimePickerData.Value = DateTime.Today;
            uxComboBoxSuport.Text = "";
        }

        private void uxButtonSalveaza_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = GetConexiune();
            if (conn == null)
            {
                return;
            }

            OleDbCommand salveazaCommand = new OleDbCommand();
            salveazaCommand.Connection = conn;
            if (uxTextBoxInv.Text == "-1")
            {
                //insert
                salveazaCommand.CommandText = "insert into Albume(Data, Denumire, Artist, Pret, Suport) values(@data, @denumire, @artist, @pret, @suport)";
            }
            else
            {
                //update
                salveazaCommand.CommandText = "update Albume set Data=@data, Denumire=@denumire, Artist=@artist, Pret=@pret, Suport=@suport where ID=@id";
            }

            OleDbParameter dataParam = new OleDbParameter();
            dataParam.ParameterName = "data";
            dataParam.DbType = DbType.Date;
            dataParam.Value = uxDateTimePickerData.Value;
            salveazaCommand.Parameters.Add(dataParam);

            salveazaCommand.Parameters.AddWithValue("denumire", uxTextBoxDenumire.Text);
            salveazaCommand.Parameters.AddWithValue("artist", uxTextBoxArtist.Text);
            salveazaCommand.Parameters.AddWithValue("pret", double.Parse(uxTextBoxPret.Text));
            salveazaCommand.Parameters.AddWithValue("suport", uxComboBoxSuport.Text);

            if (uxTextBoxInv.Text != "-1")
            {
                //update
                salveazaCommand.Parameters.AddWithValue("id", long.Parse(uxTextBoxInv.Text));
            }


            int afectate = salveazaCommand.ExecuteNonQuery();
            if (afectate > 0)
            {
                MessageBox.Show("Albumul a fost salvat cu succes!");
            }
            else
            {
                MessageBox.Show("Abumul nu a putut fi salvat!");
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
    }
}
