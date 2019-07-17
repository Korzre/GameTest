using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Jogo_em_Teste
{
    public partial class Form1 : Form
    {
        private OleDbConnection conexao;
        private OleDbCommand comando;
        private string strcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pontuacoes.mdb";
        
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            progressBar1.Visible = false;
            panel1.Visible = false;
            textBox1.Visible = false;
            label2.Text = "BE CAREFULL WITH\nTIME!";
            Carrega();
        }

        public void Carrega()
        {
           
        }

        public void Gravar()
        {
           
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            if (progressBar1.Value == 1)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            if (progressBar1.Value == 30)
            {
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            if (progressBar1.Value == 33)
            {
                button4.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button1.Visible = false;
            }
            if (progressBar1.Value == 35)
            {
                button2.Visible = true;
                button4.Visible = false;
                button3.Visible = false;
                button1.Visible = false;
            }
            if (progressBar1.Value == 39)
            {
                button1.Visible = true;
                button4.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
            }
            if (progressBar1.Value == 42)
            {
                button3.Visible = true;
                button4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            if (progressBar1.Value == 46)
            {
                button4.Visible = true;
                button3.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            if (progressBar1.Value == 49)
            {
                button1.Visible = true;
                button4.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
            }
            if (progressBar1.Value == 52)
            {
                button3.Visible = true;
                button4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            if (progressBar1.Value == 56)
            {
                button2.Visible = true;
                button4.Visible = false;
                button1.Visible = false;
                button3.Visible = false;
            }
            if (progressBar1.Value == 62)
            {
                button3.Visible = true;
                button4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            if (progressBar1.Value == 65)
            {
                button4.Visible = true;
                button4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            if (progressBar1.Value == 69)
            {
                button1.Visible = true;
                button4.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
            }
            if (progressBar1.Value == 72)
            {
                button3.Visible = true;
                button4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            if (progressBar1.Value == 77)
            {
                button1.Visible = true;
                button4.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
            }
            if (progressBar1.Value == 81)
            {
                button3.Visible = false;
                button4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                panel1.Visible = true;
            }
            if (progressBar1.Value == 92)
            {
                button3.Visible = false;
                button4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                panel1.Visible = false;
                textBox1.Visible = true;
                textBox1.Location = new Point(52, 76);
                textBox1.Size = new Size(680, 401);
                if (txtbox == 0)
                {
                    Application.Exit();
                }
                else
                {
                    Gravar();
                }
                
            }
            if (progressBar1.Value == 100)
            {
                button3.Visible = false;
                button4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                panel1.Visible = false;

                Form1 vic = new Form1();
                vic.Show();
                this.Hide();
                timer1.Stop();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int txtbox;
            txtbox = Convert.ToInt32(textBox1.Text);


            txtbox++;

            textBox1.Text = (txtbox).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            txtbox++;

            textBox1.Text = (txtbox).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            txtbox++;

            textBox1.Text = (txtbox).ToString();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            txtbox++;

            textBox1.Text = (txtbox).ToString();
        }

        public int txtbox { get; set; }
    }
}
