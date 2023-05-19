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
    public partial class Form5 : Form
    {
        public static string takedata = string.Empty;
        public static string score = string.Empty;
        public static string time = string.Empty;
        public Form5()
        {
            InitializeComponent(); // ghi lai cac thay doi khi thiet ke tren file design cua chinh no
            adddata();
        }

        void adddata()
        {
            // truyen du lieu cho bang highest score
            ListViewItem item = listViewScore.Items.Add((listViewScore.Items.Count + 1).ToString());
            item.SubItems.Add(takedata);
            item.SubItems.Add(score);
            item.SubItems.Add(time);

            // lam moi cac bien sau khi da gui du lieu
            takedata = string.Empty;
            score = string.Empty;
            time = string.Empty;
        }

        private void back_Click(object sender, EventArgs e) // tro lai form2 
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
