using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restoran
{
    public partial class FormLogin : Form
    {        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Unesite sve podatke");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = konekcija.connect();
                    SqlCommand komanda = new SqlCommand("select * from gost where email = @username", veza);
                    komanda.Parameters.AddWithValue("@username", textBoxUser.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    int c = tabela.Rows.Count;
                    if (c == 1)
                    {
                        if (string.Compare(tabela.Rows[0]["pass"].ToString(), textBoxPassword.Text) == 0)
                        {
                            MessageBox.Show("Dobrodosli!");
                            Program.userIme = tabela.Rows[0]["ime"].ToString();
                            Program.userPrezime = tabela.Rows[0]["prezime"].ToString();
                            Program.userID = (int)tabela.Rows[0]["id"];
                            this.Hide();

                            Rezervacije formRezervacije = new Rezervacije();
                            formRezervacije.Show();
                        }
                        else
                        {
                            MessageBox.Show("Pogresna lozinka!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeci email!");
                    }
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
