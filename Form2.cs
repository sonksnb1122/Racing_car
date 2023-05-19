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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); // ghi lai cac thay doi khi thiet ke tren file design cua chinh no
        }

        private void startgame_Click(object sender, EventArgs e)
        {
            this.Hide(); // ẩn đi form hiện tại
            Form3 form3 = new Form3(); 
            form3.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // ket thuc chuong trinh
        }

        private void highestscore_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void guide_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6(); 
            form6.Show();
        }
    }
}
