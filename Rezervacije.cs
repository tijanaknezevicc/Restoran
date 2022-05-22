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
    public partial class Rezervacije : Form
    {
        DataTable dtRezervacije;
        int current = 0;

        public Rezervacije()
        {
            InitializeComponent();
        }

        private void Rezervacije_Load(object sender, EventArgs e)
        {
            string user = Program.userIme + " " + Program.userPrezime;
            labelUser.Text = user;

            gridPopulate();
        }

        private void gridPopulate()
        {
            SqlConnection veza = konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter($"select rezervacija.id, gost.ime + ' ' + gost.prezime as gost, sto.kapacitet as 'broj osoba', termin.vreme as vreme, termin.datum as datum from rezervacija join gost on gost.id = gostID join sto on sto.id = stoID join termin on termin.id = terminID where gostID = {Program.userID}", veza);
            dtRezervacije = new DataTable();
            adapter.Fill(dtRezervacije);
            dataGridView.DataSource = dtRezervacije;
            dataGridView.Columns["gost"].Visible = false;
        }

        private void Rezervacije_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NovaRezervacija formDodaj = new NovaRezervacija();
            formDodaj.Show();
            this.Hide();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {            
            string naredba = $"delete from rezervacija where id = {current}";

            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            gridPopulate();
        }

        private void dataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int brojSloga = dataGridView.CurrentRow.Index;
                if (dtRezervacije.Rows.Count != 0 && brojSloga >= 0)
                {
                    current = (int)dataGridView.Rows[brojSloga].Cells["id"].Value;
                }
            }
        }
    }
}
