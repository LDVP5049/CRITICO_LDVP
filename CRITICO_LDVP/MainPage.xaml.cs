using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CRITICO_LDVP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string critica = " "; 

        private void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            critica = nombre;
            Critica.Text = critica.ToString();
           
        }
        
        /* public void ButtonClicked(string genero)
         { 
             string gen = genero;
             Genero();
             Critica.Text = gen;
         }
         public string Genero()
         {
             string genero;
             if (Hombre.IsChecked == true && Mujer.IsChecked == false)
             {
                 genero = "Hombre";
                 return genero;
             }
             else
             {
                 genero = "Mujer";
                 return genero;
             }
         }*/
    }
}
