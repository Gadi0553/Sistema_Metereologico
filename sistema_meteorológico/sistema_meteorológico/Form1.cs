using System;
using System.Windows.Forms;
using SbsSW.SwiPlCs;


namespace sistema_meteorológico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Preguntas2 preguntas2 = new Preguntas2();
            preguntas2.Show();  
            this.Hide();
            
        }
    }
}
