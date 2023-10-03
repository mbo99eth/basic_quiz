using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (soruno == 0)
            {
                richTextBox1.Text = "C# Online Quiz";
                BtnSonraki.Text = "Start";
            }
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblSoru.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Q 1 - Which of the following variable types can be assigned a value directly in C#?";
                BtnA.Text = "Value types";
                BtnB.Text = "Reference types";
                BtnC.Text = "Pointer types";
                BtnD.Text = "All of the above.";
                label4.Text = "Value types"; // doğru cevabı bir labelda tutuyorum
                BtnSonraki.Text = "Next";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Q 2 - Which of the following defines unboxing correctly?";
                BtnA.Text = "When a value type is converted to object type, it is called unboxing.";
                BtnB.Text = "When an object type is converted to a value type, it is called unboxing.";
                BtnC.Text = "Both of the above.";
                BtnD.Text = "None of the above.";
                label4.Text = "When an object type is converted to a value type, it is called unboxing."; // doğru cevabı bir labelda tutuyorum
                BtnSonraki.Text = "Sonraki";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Q 3 - Which of the following converts a floating point or integer type to a decimal type in C#?";
                BtnA.Text = "ToDouble";
                BtnB.Text = "ToInt16";
                BtnC.Text = "ToInt32";
                BtnD.Text = "ToDecimal";
                label4.Text = "19ToDecimal91"; // doğru cevabı bir labelda tutuyorum
                BtnSonraki.Text = "Game Over";
            }

            if (soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Congratulations! \n The quiz is over!");
            }

        }

        private void BtnA_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click_1(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click_1(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click_1(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

    }
}
