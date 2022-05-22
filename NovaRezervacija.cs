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
    public partial class NovaRezervacija : Form
    {
        public NovaRezervacija()
        {
            InitializeComponent();
        }

        private void NovaRezervacija_Load(object sender, EventArgs e)
        {
            string user = Program.userIme + " " + Program.userPrezime;
            labelUser.Text = user;

            dateTimePicker.CustomFormat = "d-MMM-yyyy HH:mm";
        }

        private void dodajTermin()
        {
            string datum = dateTimePicker.Value.ToString("yyyy/MM/dd");
            string vreme = dateTimePicker.Value.ToString("HH:mm");

            string naredba = $"insert into termin (datum, vreme) values('{datum}', '{vreme}')";
            //MessageBox.Show(naredba);
            
            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            dodajTermin();

            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand("select * from termin", veza);

            SqlDataAdapter adapter = new SqlDataAdapter(komanda);
            DataTable termini = new DataTable();
            adapter.Fill(termini);

            int terminID = (int)termini.Rows[termini.Rows.Count - 1]["id"]; 

            string naredba = $"insert into rezervacija (gostID, stoID, terminID) values({Program.userID}, {(int)comboBoxBrojGostiju.SelectedIndex + 1}, {terminID})";
            //MessageBox.Show(naredba);

            //SqlConnection veza = konekcija.connect();
            komanda = new SqlCommand(naredba, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();

                MessageBox.Show("rezervisano!");
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            Rezervacije formRezervacije = new Rezervacije();
            formRezervacije.Show();

            this.Close();
        }
    }
}
