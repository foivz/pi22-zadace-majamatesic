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
    public partial class frmPrikaz : Form
    {
        public frmPrikaz()
        {
            InitializeComponent();
        }

        private void frmPrikaz_Load(object sender, EventArgs e)
        {
            List<Oprema> list = RepozitorijOpreme.DohvatiOpremu();
            gridPrikaz.DataSource = list;
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            gridPrikaz.DataSource = null;
            gridPrikaz.DataSource = RepozitorijOpreme.DohvatiOpremu();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string trazi = tbxPretrazi.Text;
            gridPrikaz.DataSource = null;
            gridPrikaz.DataSource = RepozitorijOpreme.DohvatiOpremu(trazi);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (gridPrikaz.CurrentRow.DataBoundItem != null)
            {
                Oprema oprema = gridPrikaz.CurrentRow.DataBoundItem as Oprema;
                DialogResult result = MessageBox.Show("Zelite li sigurno obrisati zapis", "Brisanje zapisa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RepozitorijOpreme.ObrisiOpremu(oprema);
                    gridPrikaz.DataSource = null;
                    gridPrikaz.DataSource = RepozitorijOpreme.DohvatiOpremu();
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodavanjeIPromjena dodavanjeIPromjena = new DodavanjeIPromjena();
            dodavanjeIPromjena.ShowDialog();
            gridPrikaz.DataSource = null;
            gridPrikaz.DataSource = RepozitorijOpreme.DohvatiOpremu();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (gridPrikaz.CurrentRow.DataBoundItem != null)
            {
                Oprema oprema = gridPrikaz.CurrentRow.DataBoundItem as Oprema;

                DodavanjeIPromjena dodavanjeIPromjena = new DodavanjeIPromjena(oprema);
                dodavanjeIPromjena.ShowDialog();
                gridPrikaz.DataSource = null;
                gridPrikaz.DataSource = RepozitorijOpreme.DohvatiOpremu();
            }
        }
    }
}
