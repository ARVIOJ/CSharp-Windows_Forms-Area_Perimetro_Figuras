using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    namespace ejedos
    {
        class validar
        {
            public static void SoloNumeros(KeyPressEventArgs pE)
            {
                //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if (Char.IsControl(pE.KeyChar)) //permitir teclas de control como retroceso
                {
                    pE.Handled = false;
                }
                else if (Char.IsPunctuation(pE.KeyChar))//permitir teclas de puntuacion
                {
                    pE.Handled = false;
                }
                else //el resto de teclas pulsadas se desactivan
                {
                    pE.Handled = true;
                }

                }

            public static void SoloLetras(KeyPressEventArgs pE)
            {
                //Para obligar a que sólo se introduzcan letras
                    if (Char.IsLetter(pE.KeyChar))
                    {
                    pE.Handled = false;
                }
                else if (Char.IsControl(pE.KeyChar))//permitir teclas de control como retroceso
                {
                    pE.Handled = false;
                }
                else if (Char.IsSeparator(pE.KeyChar))//permite tecla de espacio
                {
                    pE.Handled = false;
                }
                else //el resto de teclas pulsadas se desactivan
                {
                    pE.Handled = true;
                }
            }


        }

        }
