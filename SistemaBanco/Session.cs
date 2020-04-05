using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBanco
{
    public partial class Session : Form
    {
        public Session(string nome)
        {
            InitializeComponent();
            label2.Text = nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                double valor1 = Convert.ToDouble(textBox1.Text,CultureInfo.InvariantCulture);
            if (valor1<=0)
            
                MessageBox.Show("Deposite valor maior do que 0");

            

            label5.Text = Convert.ToString(valor1);
           
            
 

            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       

          
    }
}
