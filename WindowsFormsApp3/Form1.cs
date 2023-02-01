using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
       Random random = new Random();
       Random ran = new Random();
        AbstractLevel a;
       Doctor doc;
       Disease dis;
       Animal animal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new Level1();
            a.Play();
            animal = a.createAnimal();
            dis = a.createDisease();
            doc = a.createDoctor();
            textBox2.Text = doc.name;
            textBox1.Text = animal.type;
            textBox3.Text = dis.name;
            progressBar1.Maximum = dis.power;
            progressBar1.Value = dis.power;
            pictureBox1.ImageLocation = doc.photo;
            pictureBox2.ImageLocation = animal.photo;
            pictureBox3.ImageLocation = dis.photo;
            panel1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = new Level2();
            a.Play();
            animal = a.createAnimal();
            dis = a.createDisease();
            doc = a.createDoctor();
            textBox2.Text = doc.name;
            textBox1.Text = animal.type;
            textBox3.Text = dis.name;
            progressBar1.Maximum = dis.power;
            progressBar1.Value = dis.power;
            pictureBox1.ImageLocation = doc.photo;
            pictureBox2.ImageLocation = animal.photo;
            pictureBox3.ImageLocation = dis.photo;
            panel1.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            random = new Random();
            ran = new Random();
            int k = doc.Bonus + random.Next(1, 20) - dis.power / ran.Next(20, 25);
            if (k > 0)
            {
                try
                {
                    progressBar1.Value -= k;
                    richTextBox1.Text += k + "   ";
                }
                catch (Exception ex)
                {
                    progressBar1.Value = 0;
                    MessageBox.Show("you win");
                }
                textBox3.Text = progressBar1.Value.ToString();
            }
            else 
            {
                richTextBox1.Text += " critical miss ";
            }
        }
    }
}
