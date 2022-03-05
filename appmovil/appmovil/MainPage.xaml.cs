using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appmovil
{
    
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent(); 

            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                //declaramos nuestra variables     
                int can, c200, c100, c50, c20, c10, c5, c1;
                c200 = c100 = c50 = c20 = c10 = c5 = c1 = 0;

                float conver, centa, centa50, centa25, centa10, centa5, centa1;
                centa50 = centa25 = centa10 = centa5 = centa1 = 0.00f;

                //pedimos la cantidad de dinero al usuario y lo guardamos en las variables que evaluaremos           
                centa = float.Parse(dato.Text);

                //Dejamos unas de nuestras entradas de datos vacias
                porsidolar.Text = "";
                porsidolar2.Text = "";

                //Evaluamos que tipo de moneda usara el usuario          
                if (moneda.Text == "Q")
                {
                    conver = 1;
                    porsidolar.Text = $"Cantidad de quetzales ingresados: {dato.Text}\n";
                }
                else
                {
                    conver = 7.7f;
                    if (moneda.Text == "$")
                    {
                        porsidolar.Text = $"Cantidad de dolares ingresados: {dato.Text}\n";
                        porsidolar2.Text = $"Cantidad convertida a quetzales: {float.Parse(dato.Text) * 7.7f}";
                    }
                }
                centa = centa * conver;
                can = (int)centa;
                centa = centa - can;

                //Realizamos el desglose
                if ((can >= 200))
                {
                    c200 = (can / 200);
                    can = can - (c200 * 200);
                }
                if ((can >= 100))
                {
                    c100 = (can / 100);
                    can = can - (c100 * 100);
                }
                if ((can >= 50))
                {
                    c50 = (can / 50);
                    can = can - (c50 * 50);
                }
                if ((can >= 20))
                {
                    c20 = (can / 20);
                    can = can - (c20 * 20);
                }
                if ((can >= 10))
                {
                    c10 = (can / 10);
                    can = can - (c10 * 10);
                }
                if ((can >= 5))
                {
                    c5 = (can / 5);
                    can = can - (c5 * 5);
                }
                if ((can >= 1))
                {
                    c1 = (can / 1);
                    can = can - c1;

                }
                //Contador de centavos
                if ((centa >= 0.50))
                {
                    centa50 = 1;
                    centa = (centa - 0.50f);
                }
                if ((centa >= 0.25))
                {
                    centa25 = 1;
                    centa = (centa - 0.25f);
                }
                if ((centa >= 0.10))
                {
                    centa10 = (centa - (centa % 0.10f)) / 0.10f;
                    centa = (centa % 0.10f);
                    centa10 = (float)Math.Round(centa10, 2);
                }
                if ((centa >= 0.05))
                {
                    centa5 = (centa - (centa % 0.05f)) / 0.05f;
                    centa = (centa % 0.05f);
                    centa5 = (float)Math.Round(centa5, 2);
                }
                if ((centa >= 0.01))
                {
                    centa1 = (centa / 0.01f);
                    centa1 = (int)centa1;
                }

                b200.Text = c200.ToString();
                b100.Text = c100.ToString();
                b50.Text = c50.ToString();
                b20.Text = c20.ToString();
                b10.Text = c10.ToString();
                b5.Text = c5.ToString();
                b1.Text = c1.ToString();

                m50.Text = centa50.ToString();
                m25.Text = centa25.ToString();
                m10.Text = centa10.ToString();
                m5.Text = centa5.ToString();
                m1.Text = centa1.ToString();

               

            }

            catch { DisplayAlert("Error", "Hemos tenido un error pudo haber ingresado un valor erroneo en caso de que el problema persista reinicie la aplicacion", "Ok"); }

        }


        private void Button_Clicked_1(object sender, EventArgs e)
        {
            string quetzal = "Q";
           moneda.Text = quetzal;   
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            string dolar = "$";
            moneda.Text = dolar;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            //vaciamos lo que hayaescrito el usuario y el resultado que le haya dado
            dato.Text = "";
            b200.Text = "";
            b100.Text = "";
            b50.Text = "";
            b20.Text = "";
            b10.Text = "";
            b5.Text = "";
            b1.Text = "";

            m50.Text = "";
            m25.Text = "";
            m10.Text ="" ;
            m5.Text = "";
            m1.Text = "";
            porsidolar.Text = "";
            porsidolar2.Text = "";
        }
    }
}
