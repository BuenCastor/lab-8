using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class fDisk : Form
    {
        public fDisk(Disk t)
        {
            TheDisk = t;

            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void fTown_Load(object sender, EventArgs e)
        {
            if (TheDisk != null)
            {
                tbTyp.Text = TheDisk.Typ;
                tbCountry.Text = TheDisk.Country;
                tbSpeed.Text = TheDisk.Speed.ToString();
                tbCapacity.Text = TheDisk.Capacity.ToString();
                tbVolume.Text = TheDisk.Volume.ToString();
                tbSata.Text = TheDisk.Sata;
                chbGaranty.Checked = TheDisk.Garanty;
                chbInternet.Checked = TheDisk.Internet;
            }
        }
        public Disk TheDisk;

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheDisk.Typ = tbTyp.Text.Trim();
            TheDisk.Country = tbCountry.Text.Trim();
            TheDisk.Speed = int.Parse(tbSpeed.Text.Trim());
            TheDisk.Capacity = int.Parse(tbCapacity.Text.Trim());
            TheDisk.Volume = double.Parse(tbVolume.Text.Trim());
            TheDisk.Sata = tbSata.Text.Trim();
            TheDisk.Garanty = chbGaranty.Checked;
            TheDisk.Internet = chbInternet.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbSpeed_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSpeed.Text, "[^0-9]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSpeed.Text = tbSpeed.Text.Remove(tbSpeed.Text.Length - 1);
            }
        }

        private void tbCapacity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCapacity.Text, "[^0-9]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCapacity.Text = tbCapacity.Text.Remove(tbCapacity.Text.Length - 1);
            }
        }

        private void tbVolume_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbVolume.Text, "[^0-9]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbVolume.Text = tbVolume.Text.Remove(tbVolume.Text.Length - 1);
            }

        }
    }
}
