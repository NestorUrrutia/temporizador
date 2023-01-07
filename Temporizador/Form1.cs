using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temporizador.Properties;


namespace Temporizador
{
    public partial class Form1 : Form
    {
        int hora, minutos, segundos;
        int valor_resto, valor_decimal;
        int valor_resto_minuto, valor_decimal_minuto;
        int valor_resto_hora, valor_decimal_hora;
        System.Media.SoundPlayer sonido = new System.Media.SoundPlayer(Properties.Resources.sonido);
        


        public static Form1 instance = null;
        public Form1()
        {
            InitializeComponent();
            instance = this;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BOTON INCREMETO DE HORAS
            //-----------------------------------------------------------------

            Class_timer valores_hora = new Class_timer();

            if (pictureBox1.Tag == "0")
            {
                valores_hora.Convierte(pictureBox1, 1);
            }
            else if (pictureBox1.Tag == "1")
            {
                valores_hora.Convierte(pictureBox1, 2);
            }
            else if (pictureBox1.Tag == "2")
            {
                valores_hora.Convierte(pictureBox1, 3);
            }
            else if (pictureBox1.Tag == "3")
            {
                valores_hora.Convierte(pictureBox1, 4);
            }
            else if (pictureBox1.Tag == "4")
            {
                if (pictureBox2.Tag == "2")
                {
                    valores_hora.Convierte(pictureBox1, 0);

                    valores_hora.Convierte(pictureBox2, 0);
                }
                else
                {
                    valores_hora.Convierte(pictureBox1, 5);
                }
            }
            else if (pictureBox1.Tag == "5")
            {
                valores_hora.Convierte(pictureBox1, 6);
            }
            else if (pictureBox1.Tag == "6")
            {
                valores_hora.Convierte(pictureBox1, 7);
            }
            else if (pictureBox1.Tag == "7")
            {
                valores_hora.Convierte(pictureBox1, 8);
            }
            else if (pictureBox1.Tag == "8")
            {
                valores_hora.Convierte(pictureBox1, 9);
            }
            else if (pictureBox1.Tag == "9")
            {
                if (pictureBox2.Tag == "0")
                {
                    valores_hora.Convierte(pictureBox2, 1);
                }
                else if (pictureBox2.Tag == "1")
                {
                    valores_hora.Convierte(pictureBox2, 2);
                }

                valores_hora.Convierte(pictureBox1, 0);
            }

        }

        //BTN REINICIAR
        //-----------------------------------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.cero;
            pictureBox2.Image = Resources.cero;
            pictureBox3.Image = Resources.cero;
            pictureBox4.Image = Resources.cero;
            pictureBox5.Image = Resources.cero;
            pictureBox6.Image = Resources.cero;
        }

        //BTN CERRAR
        //-----------------------------------------------------------------------------------
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BTN PARAR
        //-----------------------------------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            //stop timer
            timer1.Enabled = false;

            // enable button incremento , decremento y reinicio.
            button1.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button9.Enabled = true;
            button6.Enabled = true;

            //stop sonido
            sonido.Stop();
        }

        //BOTON INCREMENTO DE MINUTOS
        //-----------------------------------------------------------------------------------
        private void button8_Click(object sender, EventArgs e)
        {

            Class_timer valores_minutos = new Class_timer();

            if (pictureBox4.Tag == "0")
            {
                valores_minutos.Convierte(pictureBox4,1);
            }
            else if (pictureBox4.Tag == "1")
            {
                valores_minutos.Convierte(pictureBox4, 2);
            }
            else if (pictureBox4.Tag == "2")
            {
                valores_minutos.Convierte(pictureBox4, 3);
            }
            else if (pictureBox4.Tag == "3")
            {
                valores_minutos.Convierte(pictureBox4, 4);
            }
            else if (pictureBox4.Tag == "4")
            {
                valores_minutos.Convierte(pictureBox4, 5);
            }
            else if (pictureBox4.Tag == "5")
            {
                valores_minutos.Convierte(pictureBox4, 6);
            }
            else if (pictureBox4.Tag == "6")
            {
                valores_minutos.Convierte(pictureBox4, 7);
            }
            else if (this.pictureBox4.Tag == "7")
            {
                valores_minutos.Convierte(pictureBox4, 8);
            }
            else if (this.pictureBox4.Tag == "8")
            {
                valores_minutos.Convierte(pictureBox4, 9);
            }
            else if (this.pictureBox4.Tag == "9")
            {
                if (pictureBox3.Tag == "0")
                {
                    valores_minutos.Convierte(pictureBox3, 1);
                }
                else if (pictureBox3.Tag == "1")
                {
                    valores_minutos.Convierte(pictureBox3, 2);
                }
                else if (pictureBox3.Tag == "2")
                {
                    valores_minutos.Convierte(pictureBox3, 3);
                }
                else if (pictureBox3.Tag == "3")
                {
                    valores_minutos.Convierte(pictureBox3, 4);
                }
                else if (pictureBox3.Tag == "4")
                {
                    valores_minutos.Convierte(pictureBox3, 5);
                }
                else if (pictureBox3.Tag == "5")
                {
                    valores_minutos.Convierte(pictureBox4, 0);

                    valores_minutos.Convierte(pictureBox3, 0);
                }

                valores_minutos.Convierte(pictureBox4, 0);
            }
        }

        // BOTON DRECREMENTO MINUTOS
        //-----------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {

            Class_timer valores_minutos = new Class_timer();

            if (pictureBox4.Tag == "0")
            {
                if (pictureBox3.Tag == "1")
                {
                    valores_minutos.Convierte(pictureBox3, 0);

                    valores_minutos.Convierte(pictureBox4, 9);
                }
                else if (pictureBox3.Tag == "2")
                {
                    valores_minutos.Convierte(pictureBox3, 1);

                    valores_minutos.Convierte(pictureBox4, 9);
                }
                else if (pictureBox3.Tag == "3")
                {
                    valores_minutos.Convierte(pictureBox3, 2);

                    valores_minutos.Convierte(pictureBox4, 9);
                }
                else if (pictureBox3.Tag == "4")
                {
                    valores_minutos.Convierte(pictureBox3, 3);

                    valores_minutos.Convierte(pictureBox4, 9);
                }
                else if (pictureBox3.Tag == "5")
                {
                    valores_minutos.Convierte(pictureBox3, 4);

                    valores_minutos.Convierte(pictureBox4, 9);
                }
                else if (pictureBox3.Tag == "6")
                {
                    valores_minutos.Convierte(pictureBox3, 6);

                    valores_minutos.Convierte(pictureBox4, 9);
                }
                else if (pictureBox3.Tag == "0")
                {
                    valores_minutos.Convierte(pictureBox3, 5);

                    valores_minutos.Convierte(pictureBox4, 9);
                }

            }
            else if (pictureBox4.Tag == "9")
            {
                valores_minutos.Convierte(pictureBox4, 8);
            }
            else if (pictureBox4.Tag == "8")
            {
                valores_minutos.Convierte(pictureBox4, 7);
            }
            else if (pictureBox4.Tag == "7")
            {
                valores_minutos.Convierte(pictureBox4, 6);
            }
            else if (pictureBox4.Tag == "6")
            {
                valores_minutos.Convierte(pictureBox4, 5);
            }
            else if (pictureBox4.Tag == "5")
            {
                valores_minutos.Convierte(pictureBox4, 4);
            }
            else if (pictureBox4.Tag == "4")
            {
                valores_minutos.Convierte(pictureBox4, 3);
            }
            else if (pictureBox4.Tag == "3")
            {
                valores_minutos.Convierte(pictureBox4, 2);
            }
            else if (pictureBox4.Tag == "2")
            {
                valores_minutos.Convierte(pictureBox4, 1);
            }
            else if (pictureBox4.Tag == "1")
            {
                valores_minutos.Convierte(pictureBox4, 0);
            }
        }

        // BTN MINIMIZAR
        //-----------------------------------------------------------------------------------
        private void button11_Click(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Minimized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // BTN INCREMENTO SEGUNDOS
        //-----------------------------------------------------------------------------------
        private void button9_Click(object sender, EventArgs e)
        {

            Class_timer valores_segundos = new Class_timer();

            if (pictureBox6.Tag == "0")
            {
                valores_segundos.Convierte(pictureBox6,1);
            }
            else if (pictureBox6.Tag == "1")
            {
                valores_segundos.Convierte(pictureBox6, 2);
            }
            else if (this.pictureBox6.Tag == "2")
            {
                valores_segundos.Convierte(pictureBox6, 3);
            }
            else if (this.pictureBox6.Tag == "3")
            {
                valores_segundos.Convierte(pictureBox6, 4);
            }
            else if (this.pictureBox6.Tag == "4")
            {
                valores_segundos.Convierte(pictureBox6, 5);
            }
            else if (this.pictureBox6.Tag == "5")
            {
                valores_segundos.Convierte(pictureBox6, 6);
            }
            else if (this.pictureBox6.Tag == "6")
            {
                valores_segundos.Convierte(pictureBox6, 7);
            }
            else if (this.pictureBox6.Tag == "7")
            {
                valores_segundos.Convierte(pictureBox6, 8);
            }
            else if (this.pictureBox6.Tag == "8")
            {
                valores_segundos.Convierte(pictureBox6, 9);
            }
            else if (this.pictureBox6.Tag == "9")
            {
                if (pictureBox5.Tag == "0")
                {
                    valores_segundos.Convierte(pictureBox5, 1);
                }
                else if (pictureBox5.Tag == "1")
                {
                    valores_segundos.Convierte(pictureBox5, 2);
                }
                else if (pictureBox5.Tag == "2")
                {
                    valores_segundos.Convierte(pictureBox5, 3);
                }
                else if (pictureBox5.Tag == "3")
                {
                    valores_segundos.Convierte(pictureBox5, 4);
                }
                else if (pictureBox5.Tag == "4")
                {
                    valores_segundos.Convierte(pictureBox5, 5);
                }
                else if (pictureBox5.Tag == "5")
                {
                    valores_segundos.Convierte(pictureBox6, 0);

                    valores_segundos.Convierte(pictureBox5, 0);
                }

                valores_segundos.Convierte(pictureBox6, 0);
            }
        }

        // BTN DECREMENTO SEGUNDOS
        //-----------------------------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            Class_timer valores_segundos = new Class_timer();

            if (pictureBox6.Tag == "0")
            {
                if (pictureBox5.Tag == "1")
                {
                    valores_segundos.Convierte(pictureBox5,0);

                    valores_segundos.Convierte(pictureBox6, 9);
                }
                else if (pictureBox5.Tag == "2")
                {
                    valores_segundos.Convierte(pictureBox5, 1);

                    valores_segundos.Convierte(pictureBox6, 9);
                }
                else if (pictureBox5.Tag == "3")
                {
                    valores_segundos.Convierte(pictureBox5, 2);

                    valores_segundos.Convierte(pictureBox6, 9);
                }
                else if (pictureBox5.Tag == "4")
                {
                    valores_segundos.Convierte(pictureBox5, 3);

                    valores_segundos.Convierte(pictureBox6, 9);
                }
                else if (pictureBox5.Tag == "5")
                {
                    valores_segundos.Convierte(pictureBox5, 4);

                    valores_segundos.Convierte(pictureBox6, 9);
                }
                else if (pictureBox5.Tag == "6")
                {
                    valores_segundos.Convierte(pictureBox5, 6);

                    valores_segundos.Convierte(pictureBox6, 9);
                }
                else if (pictureBox5.Tag == "0")
                {
                    valores_segundos.Convierte(pictureBox5, 5);

                    valores_segundos.Convierte(pictureBox6, 9);
                }

            }
            else if (pictureBox6.Tag == "9")
            {
                valores_segundos.Convierte(pictureBox6, 8);
            }
            else if (pictureBox6.Tag == "8")
            {
                valores_segundos.Convierte(pictureBox6, 7);
            }
            else if (pictureBox6.Tag == "7")
            {
                valores_segundos.Convierte(pictureBox6, 6);
            }
            else if (pictureBox6.Tag == "6")
            {
                valores_segundos.Convierte(pictureBox6, 5);
            }
            else if (pictureBox6.Tag == "5")
            {
                valores_segundos.Convierte(pictureBox6, 4);
            }
            else if (pictureBox6.Tag == "4")
            {
                valores_segundos.Convierte(pictureBox6, 3);
            }
            else if (pictureBox6.Tag == "3")
            {
                valores_segundos.Convierte(pictureBox6, 2);
            }
            else if (pictureBox6.Tag == "2")
            {
                valores_segundos.Convierte(pictureBox6, 1);
            }
            else if (pictureBox6.Tag == "1")
            {
                valores_segundos.Convierte(pictureBox6, 0);
            }
        }

        //BTN TIMER
        //-----------------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            Class_timer seg = new Class_timer();

            if ((hora == 0)&&(minutos==0)&&(segundos==0))
            {

                //stop timer
                this.timer1.Stop();

                // enable button incremento / decremento & reinicio.
                button1.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button9.Enabled = true;
                button6.Enabled = true;

                //Activo sonido
                sonido.PlayLooping();

               //show mensaje escrito en richtextbox
                //MessageBox.Show(richTextBox1.Text, "Aviso!!!!!!!!!!");

                Form2 pantalla2= new Form2(richTextBox1.Text,sonido);
                this.Hide();
                pantalla2.Show();

            }
            else if ((minutos == 0) && (hora != 0))
            {
                minutos = 59;
                valor_resto_minuto = minutos % 10;
                valor_decimal_minuto = minutos / 10;

                seg.Convierte(pictureBox4, valor_resto_minuto);
                seg.Convierte(pictureBox3, valor_decimal_minuto);

                hora -= 1;
                valor_resto_hora = hora % 10;
                valor_decimal_hora = hora / 10;
                seg.Convierte(pictureBox1, valor_resto_hora);
                seg.Convierte(pictureBox2, valor_decimal_hora);

                segundos =59;

                valor_resto = segundos % 10;
                valor_decimal = segundos / 10;

                seg.Convierte(pictureBox6, valor_resto);
                seg.Convierte(pictureBox5, valor_decimal);
            }
            else if ((segundos == 0) && (minutos != 0))
            {
                segundos = 59;
                valor_resto = segundos % 10;
                valor_decimal = segundos / 10;
                

                seg.Convierte(pictureBox6, valor_resto);
                seg.Convierte(pictureBox5, valor_decimal);

                minutos -= 1;
                valor_resto_minuto = minutos % 10;
                valor_decimal_minuto = minutos / 10;
                seg.Convierte(pictureBox4, valor_resto_minuto);
                seg.Convierte(pictureBox3, valor_decimal_minuto);
            }
            else
            {
                segundos -= 1;

                valor_resto = segundos % 10;
                valor_decimal = segundos / 10;

                seg.Convierte(pictureBox6, valor_resto);
                seg.Convierte(pictureBox5, valor_decimal);
            }
        
           
        }

        //BTN DECREMENTO DE HORAS
        //-----------------------------------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            Class_timer valores_hora = new Class_timer();

            if (pictureBox1.Tag == "0")
            {
                if (pictureBox2.Tag == "1")
                {
                    valores_hora.Convierte(pictureBox2, 0);

                    valores_hora.Convierte(pictureBox1, 9);
                }
                else if (pictureBox2.Tag == "2")
                {
                    valores_hora.Convierte(pictureBox2, 1);

                    valores_hora.Convierte(pictureBox1, 9);
                }
                else if (pictureBox2.Tag == "0")
                {
                    valores_hora.Convierte(pictureBox2, 2);

                    valores_hora.Convierte(pictureBox1, 4);
                }

            }
            else if(pictureBox1.Tag == "9")
            {
                valores_hora.Convierte(pictureBox1, 8);
            }
            else if (pictureBox1.Tag == "8")
            {
                valores_hora.Convierte(pictureBox1, 7);
            }
            else if (pictureBox1.Tag == "7")
            {
                valores_hora.Convierte(pictureBox1, 6);
            }
            else if (pictureBox1.Tag == "6")
            {
                valores_hora.Convierte(pictureBox1, 5);
            }
            else if (pictureBox1.Tag == "5")
            {
                valores_hora.Convierte(pictureBox1, 4);
            }
            else if (pictureBox1.Tag == "4")
            {
                valores_hora.Convierte(pictureBox1, 3);
            }
            else if (pictureBox1.Tag == "3")
            {
                valores_hora.Convierte(pictureBox1, 2);
            }
            else if (pictureBox1.Tag == "2")
            {
                valores_hora.Convierte(pictureBox1, 1);
            }
            else if (pictureBox1.Tag == "1")
            {
                valores_hora.Convierte(pictureBox1, 0);
            }

        }

        //BTN INICIAR
        //-----------------------------------------------------------------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            // obtengo horas minutos y segundos
            hora = (Int16.Parse(pictureBox2.Tag.ToString())*10)+(Int16.Parse(pictureBox1.Tag.ToString()));
            minutos= (Int16.Parse(pictureBox3.Tag.ToString()) * 10) + (Int16.Parse(pictureBox4.Tag.ToString()));
            segundos = (Int16.Parse(pictureBox5.Tag.ToString()) * 10) + (Int16.Parse(pictureBox6.Tag.ToString()));

            // desabilito button incremento y decremento.
            button1.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button9.Enabled = false;
            button6.Enabled= false;

            //habilito el timer
            timer1.Enabled=true;

        }
    }
}
