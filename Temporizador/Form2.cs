using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer sonido2 = new System.Media.SoundPlayer();

        public Form2(string mensaje, System.Media.SoundPlayer sonido)
        {
            sonido2 = sonido;
            InitializeComponent();
            richTextBox1.Text= mensaje;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form1.instance.timer1.Enabled = false;
            sonido2.Stop();
            Form1.instance.Show();
            this.Close();
           
        }
    }
}
