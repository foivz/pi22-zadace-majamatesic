using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registar_opreme
{
    public partial class DodavanjeIPromjena : Form
    {
        public DodavanjeIPromjena(Oprema uredi = null)
        {
            InitializeComponent();
            Uredi = uredi;
        }

        public Oprema Uredi { get; set; }

        private void DodavanjeIPromjena_Load(object sender, EventArgs e)
        {
            if (Uredi != null)
            {
                tbxId.Text = Uredi.ID_oprema.ToString();
                tbxNaziv.Text = Uredi.nazivOpreme;
                tbxVrsta.Text = Uredi.vrstaOpreme;
                numKolicina.Value = Uredi.kolicinaJediniceOpreme;
                numDostupno.Value = Uredi.dostupnoOpreme;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Uredi != null)
            {
                Uredi.nazivOpreme = tbxNaziv.Text;
                Uredi.vrstaOpreme = tbxVrsta.Text;
                Uredi.kolicinaJediniceOpreme = (int)numKolicina.Value;
                Uredi.dostupnoOpreme = (int)numDostupno.Value;

                RepozitorijOpreme.UrediOpremu(Uredi);
            }
            else
            {
                Uredi = new Oprema();
                Uredi.nazivOpreme = tbxNaziv.Text;
                Uredi.vrstaOpreme = tbxVrsta.Text;
                Uredi.kolicinaJediniceOpreme = (int)numKolicina.Value;
                Uredi.dostupnoOpreme = (int)numDostupno.Value;

                RepozitorijOpreme.DodajOpremu(Uredi);
            }
            Close();
        }
    }
}
