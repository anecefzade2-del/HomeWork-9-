
using System;
using System.Media;
using System.Windows.Forms;

namespace Cat_bomb
{
    public partial class Form1 : Form
    {
        string path = "C:\\Users\\AN\\Downloads\\";

        Random r = new Random();

        int score = 0;
        int bombNum;

        bool gameOver = false;

        bool open1 = false;
        bool open2 = false;
        bool open3 = false;
        bool open4 = false;
        bool open5 = false;
        bool open6 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewGame()
        {
            bombNum = r.Next(1, 7);

            score = 0;
            gameOver = false;

            open1 = false;
            open2 = false;
            open3 = false;
            open4 = false;
            open5 = false;
            open6 = false;

            label2.Text = score.ToString();

            pictureBox1.ImageLocation = path + "question.png";
            pictureBox2.ImageLocation = path + "question.png";
            pictureBox3.ImageLocation = path + "question.png";
            pictureBox4.ImageLocation = path + "question.png";
            pictureBox5.ImageLocation = path + "question.png";
            pictureBox6.ImageLocation = path + "question.png";
        }

        private void Check(PictureBox pb, int num)
        {
            if (bombNum == num)
            {
                pb.ImageLocation = path + "bomba.png";

                SoundPlayer sound = new SoundPlayer(path + "explosion.wav");
                sound.Play();

                MessageBox.Show("Oyun bitdi!");

                gameOver = true;
            }
            else
            {
                pb.ImageLocation = path + "cat.png";

                score += 1;
                label2.Text = Convert.ToString(score);

                if (score >= 5)
                {
                    MessageBox.Show("Təbriklər! Oyunu qazandınız!");
                    gameOver = true;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (open3 == true || gameOver == true)
                return;

            open3 = true;
            Check(pictureBox3, 3);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (open1 == true || gameOver == true)
                return;

            open1 = true;
            Check(pictureBox1, 1);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (open5 == true || gameOver == true)
                return;

            open5 = true;
            Check(pictureBox5, 5);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (open2 == true || gameOver == true)
                return;

            open2 = true;
            Check(pictureBox2, 2);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (open6 == true || gameOver == true)
                return;

            open6 = true;
            Check(pictureBox6, 6);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (open4 == true || gameOver == true)
                return;

            open4 = true;
            Check(pictureBox4, 4);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
