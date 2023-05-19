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
    public partial class Form1 : Form
    {
        public static string selectlv = string.Empty;
        public Form1()
        {
            InitializeComponent();// ghi lai cac thay doi khi thiet ke tren file design cua chinh no
            selectlevel(); // goi ham selectelvel
            
        }
      
        private void timer1_Tick(object sender, EventArgs e) // ham su dung thoi gian 
        {
            linemove(carspeed);
            gameover();
            showtext();
        }

        int score;

        Random pos = new Random();
        void linemove(int speed) 
        {
            // thiet ke di chuyen cho cac xe ke dich
            if (pictureBox1.Top > 495) pictureBox1.Top = 0;
            else pictureBox1.Top += speed;
            if (pictureBox2.Top > 495) pictureBox2.Top = 0;
            else pictureBox2.Top += speed;
            if (pictureBox3.Top > 495) pictureBox3.Top = 0;
            else pictureBox3.Top += speed;
            if (pictureBox4.Top > 495) pictureBox4.Top = 0;
            else pictureBox4.Top += speed;
            if (pictureBox5.Top > 495) pictureBox5.Top = 0;
            else pictureBox5.Top += speed;
            if (pictureBox6.Top > 495) pictureBox6.Top = 0;
            else pictureBox6.Top += speed;
            if (pictureBox7.Top > 495) pictureBox7.Top = 0;
            else pictureBox7.Top += speed;
            if (pictureBox8.Top > 495) pictureBox8.Top = 0;
            else pictureBox8.Top += speed;
            if (pictureBox9.Top > 495) pictureBox9.Top = 0;
            else pictureBox9.Top += speed;
            if (pictureBox10.Top > 495) pictureBox10.Top = 0;
            else pictureBox10.Top += speed;
            if (pictureBox11.Top > 495) pictureBox11.Top = 0;
            else pictureBox11.Top += speed;
            if (pictureBox12.Top > 495) pictureBox12.Top = 0;
            else pictureBox12.Top += speed;
            if (pictureBox13.Top > 495) pictureBox13.Top = 0;
            else pictureBox13.Top += speed;
            if (pictureBox14.Top > 495) pictureBox14.Top = 0;
            else pictureBox14.Top += speed;
            if (pictureBox15.Top > 495) pictureBox15.Top = 0;
            else pictureBox15.Top += speed;
            if (pictureBox16.Top > 495) pictureBox16.Top = 0;
            else pictureBox16.Top += speed;
            if (pictureBox17.Top > 495) pictureBox17.Top = 0;
            else pictureBox17.Top += speed;
            if (pictureBox18.Top > 495) pictureBox18.Top = 0;
            else pictureBox18.Top += speed;
            if (pictureBox19.Top > 495) pictureBox19.Top = 0;
            else pictureBox19.Top += speed;
            if (pictureBox20.Top > 495) pictureBox20.Top = 0;
            else pictureBox20.Top += speed;
            if (pictureBox21.Top > 495) pictureBox21.Top = 0;
            else pictureBox21.Top += speed;
            if (pictureBox22.Top > 495) pictureBox22.Top = 0;
            else pictureBox22.Top += speed;
            if (pictureBox23.Top > 495) pictureBox23.Top = 0;
            else pictureBox23.Top += speed;
            if (pictureBox24.Top > 495) pictureBox24.Top = 0;
            else pictureBox24.Top += speed;

            // thiet ke cho cac xe khi da di qua duong bien ben duoi
            if (enemy1.Top > 495) 
            {
                score += carspeed;
                enemy1.Left = pos.Next(200, 270);
                enemy1.Top = pos.Next(0, 40);
                enemy1.Top = 0;
            }
            else enemy1.Top += speed;
            if (enemy2.Top > 495)
            {
                score += carspeed;
                enemy2.Left = pos.Next(200, 270);
                enemy2.Top = pos.Next(0, 40);
                enemy2.Top = 0;
            }
            else enemy2.Top += speed;
            if (enemy3.Top > 495)
            {
                score = score + carspeed + carspeed / 4;
                enemy3.Left = pos.Next(20, 120);
                enemy3.Top = pos.Next(0, 40);
                enemy3.Top = 0;
            }
            else enemy3.Top = enemy3.Top + speed + speed/4;
            if (enemy4.Top > 495)
            {
                score = score + carspeed + carspeed / 3;
                enemy4.Left = pos.Next(20, 120);
                enemy4.Top = pos.Next(0, 40);
                enemy4.Top = 0;
            }
            else enemy4.Top = enemy4.Top + speed + speed/3;
            if (enemy5.Top > 495)
            {
                score = score + carspeed + carspeed / 2;
                enemy5.Left = pos.Next(120, 200);
                enemy5.Top = pos.Next(0, 40);
                enemy5.Top = 0;
            }
            else enemy5.Top = enemy5.Top + speed + speed/2;
        }

        int carspeed;
        void selectlevel()
        {
            // cai toc do xe khi chon level     
            if (Form1.selectlv == "Easy")
            {
                carspeed = 3;
            }
            else if (Form1.selectlv == "Hard")
            {
                carspeed = 7;
            }
            else if (Form1.selectlv == "Hell")
            {
                carspeed = 12;
            }
            else carspeed = 5;
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // thiet ke dieu khien cho xe 
            if (e.KeyCode == Keys.Left && Car.Left > 0) Car.Left -= 15;
            if (e.KeyCode == Keys.Right && Car.Left < 300) Car.Left += 15;
            if (e.KeyCode == Keys.Up && carspeed < 30) Car.Top -= carspeed;
            if (Car.Top >= 440) Car.Top = 440;
            if (e.KeyCode == Keys.Down && carspeed > 3) Car.Top += carspeed;
            if (Car.Top <= 0) Car.Top = 0;
        }

        void showtext()
        {
            // hien diem va toc do cua nguoi choi tren label text
            LvSpeed.Text = "Speed : " + carspeed;
            Score.Text = "Score : " + score;
        }

        void gameover()
        {
            if (Car.Bounds.IntersectsWith(enemy1.Bounds) || Car.Bounds.IntersectsWith(enemy2.Bounds) || Car.Bounds.IntersectsWith(enemy3.Bounds) || Car.Bounds.IntersectsWith(enemy4.Bounds) || Car.Bounds.IntersectsWith(enemy5.Bounds))
            {
                timer1.Stop(); // dung lai timer1
                // .visible = true de hien len cac button va label sau khi bi thua
                playagain.Visible = true; 
                endgame.Visible = true;
                takename.Visible = true;
            }
        }

        private void playagain_Click(object sender, EventArgs e)
        {
            // lay ten va diem cua nguoi choi dua vao highest score o form5
            if (takename.Text == "" || takename.Text == "Enter Your Name") { Form5.takedata = "Unknown Player"; }
            else if (takename.Text != "Enter Your Name" && takename.Text.Length >= 1 ) { Form5.takedata = takename.Text; }
            else { Form5.takedata = "Unknown Player"; }
            Form5.takedata = takename.Text;
            Form5.score = "" + score;
            this.Close(); // dong lai form hien tai
            Form2 form2 = new Form2(); // tao mot form2 moi
            form2.Show(); // hien len form2 vua tao
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // lay thoi gian hien tai
            DateTime tn = DateTime.Now;
            Form5.time = tn.ToString("HH:mm");
        }

        private void takename_Enter(object sender, EventArgs e) // lay ten nguoi choi
        {
            if (takename.Text == "Enter Your Name" || takename.Text == null)
            {
                takename.Text = "";
                takename.BackColor = Color.White;
                takename.ForeColor = Color.Black;
            }      
        }
    }
}