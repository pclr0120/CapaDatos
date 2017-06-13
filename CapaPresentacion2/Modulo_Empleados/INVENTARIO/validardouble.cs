using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Inventario
{
    public class validardouble
    {


       public  bool ContadoPuntos = false;
 
        public bool SoloNumeros(KeyPressEventArgs e,string t)
        {
            //se convierte a Ascci del la tecla presionada 

            int ascci = Convert.ToInt32(Convert.ToChar(e.KeyChar));
            //verificamos que se encuentre en ese rango que son entre el 0 y el 9 
      
           
                if (t.Contains(".") != true) {
                    ContadoPuntos = false;
                }
                if (ContadoPuntos != true && t.Contains(".") != true)
                {
                    if ((ascci >= 48 && ascci <= 57) || ascci == 46 || ascci == 8)
                    {

                        if (ascci == 46)
                        {
                        if (t.Length ==0)
                        {

                            MessageBox.Show("No se puede ingresar el punto en la primera posicion");
                            return true;
                        }
                     
                  
                            ContadoPuntos = true;
                            return false;
                        

                        }
                        return e.Handled = false;
                    }
                    else
                    {
                        return e.Handled = true;
                    }
                }
                else
                {


                    if ((ascci >= 48 && ascci <= 57) || ascci == 46 || ascci == 8)
                    {

                        if (ascci == 46)
                        {
                            MessageBox.Show("Solo se puede un punto en la cifra borralo para colocarlo en otra parte", "Mensaje");
                            return e.Handled = true;

                        }
                        else {

                            return e.Handled = false;
                        }


                    }
                    else
                    {
                        return e.Handled = true;
                    }

                }
            //}
            //else {
            //    MessageBox.Show("No se puede ingresar el punto en la primera posicion");
            //    return true;
            //}
        }
    }
}
