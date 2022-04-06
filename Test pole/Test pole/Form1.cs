using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_pole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            char[] pole = new char[Convert.ToInt32(numericUpDown1.Value)];
            char[] poleAlfa = new char[Convert.ToInt32(numericUpDown1.Value)];
            char[] poleSerazeno = new char[Convert.ToInt32(numericUpDown1.Value)];
            Random rng = new Random();

            for(int i = 0;i < Convert.ToInt32(numericUpDown1.Value);i++)
            {
                pole[i] = Convert.ToChar(rng.Next(33,127));
            }
            foreach(char znak in pole)
            {
                listBox1.Items.Add(znak);
            }
            Array.Reverse(pole);
            foreach(char znak in pole)
            {
                listBox2.Items.Add(znak);
            }
            int j = 0;
            bool AlfaVyskyt = false;
            for(int i = 0;i< Convert.ToInt32(numericUpDown1.Value); i++)
            {
                if(pole[i] >= '0' && pole[i] <= '9' || pole[i]>= 'A' && pole[i] <= 'Z' || pole[i] >= 'a' && pole[i] <='z')
                {
                    AlfaVyskyt = true;
                    poleAlfa[j] = pole[i];
                    j++;
                }
            }
            if(AlfaVyskyt == true)
            {
                int a = 0;
                for (int i = 0; i < j; i++)
                {
                    textBox1.Lines[a] = Convert.ToString(poleAlfa[i]);
                    //a++; tady to padá nevím proč:(
                }
            }
            else
            {
                textBox1.Text = "Nejsou žádné Alfanumerické znaky";
            }
            
        }
    }
}
