using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizce_Oyunu_2._0
{
    public partial class Form1 : Form
    {

        public List<TextBox> textBoxList = new List<TextBox>();
        public int control;
       
        void Setalltext(int a)
        {
            //ingilizceler açık sadece
                Fileoperations.Takewords();
            for (int i = 0; i < 10; i++)
            {
                 textBoxList[i].Text = Fileoperations.words[i][a]; // a==0 sa sadece ingilizceler ,açık a==1 se sadece türkçeler açık
                
            }
        }

        public void Writetextline(int b)
        {

            textBoxList[b-1].Text = Fileoperations.words[b - 1][0] + " : " + Fileoperations.words[b - 1][1];

        }



        public Form1()
        {
            InitializeComponent();
        }
      
        
        private void Form1_Load(object sender, EventArgs e)
        {

            Randomm.Randomnumber();
            Fileoperations.Readingfile();
       
            textBoxList.Add(this.textBox1);
            textBoxList.Add(this.textBox2);
            textBoxList.Add(this.textBox3);
            textBoxList.Add(this.textBox4);
            textBoxList.Add(this.textBox5);
            textBoxList.Add(this.textBox6);
            textBoxList.Add(this.textBox7);
            textBoxList.Add(this.textBox8);
            textBoxList.Add(this.textBox9);
            textBoxList.Add(this.textBox10);
            // textboxlist oluşumu
          
            Setalltext(0);


        }
       private void button1_Click(object sender, EventArgs e)
       {
            Writetextline(1);
       }

        private void button2_Click(object sender, EventArgs e)
        {
            Writetextline(2);
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Writetextline(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Writetextline(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Writetextline(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Writetextline(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Writetextline(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Writetextline(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Writetextline(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Writetextline(10);

        }

        private void button11_Click(object sender, EventArgs e)
        {
          Setalltext(0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
          Setalltext(1);
        }

        
    }
}

