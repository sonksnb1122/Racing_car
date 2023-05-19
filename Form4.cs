using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Racing
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();// ghi lai cac thay doi khi thiet ke tren file design cua chinh no
            cirload.Value = 0; // dat lai gia tri cua vong tron load
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {    
            // cai dat hoat dong cho circularProgressBar
            cirload.Value += 10;
            progress.Text = cirload.Value.ToString() + "%";
            if ( cirload.Value == 20 ) ready.Text = "3";
            if ( cirload.Value == 40 ) ready.Text = "2";
            if ( cirload.Value == 60 ) ready.Text = "1";
            if ( cirload.Value == 80 ) ready.Text = "GO";
            if ( cirload.Value == 100 )
            {
                timercir.Enabled = false; // dung lai timer1_Tick
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
}
