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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
             "Припинити роботу", MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnAddTown_Click(object sender, EventArgs e)
        {
            Disk disk = new Disk();
            fDisk ft = new fDisk(disk);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbDiskInfo.Text +=
                string.Format("Тип: {0}, Країна виробник: {1}, Швидкість передачі данних: {2} гб/c , Ємність: {3} Гб. Об'єм буферу: {4}  " +
                "Інтерфейс: {5} . [{6} | {7}] |  \r\n",

                disk.Typ, disk.Country, disk.Speed,
                disk.Capacity, disk.Volume, disk.Sata,
                disk.Garanty ? "Є гарантія" : "Немає гарантія",
                disk.Internet ? "Є можливість замовити через інтернет" : "Немає можливості замовити через інтернет");
            }


        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }
    }
}
