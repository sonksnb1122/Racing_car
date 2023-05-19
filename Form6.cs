using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();// ghi lai cac thay doi khi thiet ke tren file design cua chinh no
        }

        private void guideback_Click(object sender, EventArgs e) // tro lai form2
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
