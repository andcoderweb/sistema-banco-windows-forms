using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBanco
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string nome = textBox1.Text;
            Session s = new Session(nome);
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Preencha o nome para continuar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox2.Text.Length!=5) {
                MessageBox.Show("A conta deve ter 5 Digitos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox3.Text.Length != 6)
            {
                MessageBox.Show("A senha deve ter 6 Digitos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            s.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "Bem-vindo-" + DateTime.Now.ToShortDateString();

        }
    }
}
