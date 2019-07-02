using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dom_rab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b=false;
            int high=2000, low=1;
            
            do
            {
                DialogResult result = MessageBox.Show($"Число больше {(high + low) / 2}", "Угадывание числа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                
                    if (result == DialogResult.Yes)
                    { low = (high + low) / 2; MessageBox.Show($"high = {high} low = {low}"); }
                    else
                    { high = (high + low) / 2; MessageBox.Show($"high = {high} low = {low}"); }
                

                    if ((high - low) == 1 && result == DialogResult.Yes)
                    {
                    if (b == false)
                    {
                        MessageBox.Show($"загаданное числое = {high}");
                    }
                        b = true;
                    }

               


            } while (high != low && b == false);
            
        }
    }
}
