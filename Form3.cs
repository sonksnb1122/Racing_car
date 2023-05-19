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
    public partial class Form3 : Form
    { 
        public Form3()
        {
            InitializeComponent();// ghi lai cac thay doi khi thiet ke tren file design cua chinh no
        }

        private void easy_Click_1(object sender, EventArgs e)
        {
            Form1.selectlv = easy.Text; // truyen du lieu sang cho form1
            Form4 form4 = new Form4();
            this.Close(); // dong lai form hien tai
            form4.Show();
        }

        private void hard_Click(object sender, EventArgs e)
        {
            Form1.selectlv = hard.Text;
            Form4 form4 = new Form4();
            this.Close();
            form4.Show();
        }

        private void hell_Click(object sender, EventArgs e)
        {
            Form1.selectlv = hell.Text;
            Form4 form4 = new Form4();
            this.Close();
            form4.Show();
        }

    }
}
