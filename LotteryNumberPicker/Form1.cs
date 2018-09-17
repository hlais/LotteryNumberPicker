using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumberPicker
{
    public partial class Form1 : Form
    {
        Random ran = new Random();
        int[] numbers = new int[6];
       

        public Form1()
        {
            InitializeComponent();
            
        }

        private void generate_Click(object sender, EventArgs e)
        {
            //array to hold numbers
            int[] seq = new int[59];
            
            //fill array elements 0-59
            for (int i = 1; i < 60; i++)
            {
                seq[i - 1] = i;
            }
            //shuffle values in array

            //sweet algorithm
            for (int i = 0; i < 59; i++)
            {
                int randomNum = (ran.Next()%59);
                int k = seq[i];
                seq[i] = seq[randomNum];
                seq[randomNum] = k;
            }

           
            label1.Text = seq[1].ToString();
            label2.Text = seq[2].ToString();
            label3.Text = seq[3].ToString();
            label4.Text = seq[4].ToString();
            label5.Text = seq[5].ToString();
            label6.Text = seq[6].ToString();
            ClearBtn.Enabled = true;
            GenerateBtn.Enabled = false;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int randomNumber = ran.Next(0,57);
            //    numbers[i] = ran.Next(0, 57);
            //    if (numbers.Contains(randomNumber))
            //    {

            //    }
            //}
            //ShowNumbers();
        }
        public void ShowNumbers()
        {
            //no longer in use- For demo purpose.
            label1.Text = numbers[0].ToString();
            label2.Text = numbers[1].ToString();
            label3.Text = numbers[2].ToString();
            label4.Text = numbers[3].ToString();
            label5.Text = numbers[4].ToString();
            label6.Text = numbers[5].ToString();
            ClearBtn.Enabled = true;
            GenerateBtn.Enabled = false;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            Array.Clear(numbers, 0, numbers.Length);
            foreach (Label lbl in Controls.OfType<Label>())
            {
                lbl.Text = "0";
            }
            GenerateBtn.Enabled = true;
            ClearBtn.Enabled = false;
        }
    }
}
