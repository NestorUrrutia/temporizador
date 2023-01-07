using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temporizador.Properties;

namespace Temporizador
{
    internal class Class_timer
    {   
        // usado en incrementos, decrementos de horas minutos y segundos y timer
        public void Convierte(PictureBox img1, int num1)
        {

            if (num1 == 0)
            {
                img1.Image = Resources.cero;
                img1.Tag = "0";
            
            }
            else if (num1 == 1)
            {
                img1.Image = Resources.uno;
                img1.Tag = "1";
            }
            else if (num1 == 2)
            {
                img1.Image = Resources.dos;
                img1.Tag = "2";
            }
            else if (num1 == 3)
            {
                img1.Image = Resources.tres;
                img1.Tag = "3";
            }
            else if (num1 == 4)
            {
                img1.Image = Resources.cuatro;
                img1.Tag = "4";
            }
            else if (num1 == 5)
            {
                img1.Image = Resources.cinco;
                img1.Tag = "5";
            }
            else if (num1 == 6)
            {
                img1.Image = Resources.seis;
                img1.Tag = "6";
            }
            else if (num1 == 7)
            {
                img1.Image = Resources.siete;
                img1.Tag = "7";
            }
            else if (num1 == 8)
            {
                img1.Image = Resources.ocho;
                img1.Tag = "8";
            }
            else if (num1 == 9)
            {
                img1.Image = Resources.nueve;
                img1.Tag = "9";
            }
        }
    }
}
