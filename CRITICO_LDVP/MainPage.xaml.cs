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
            string genero = (Hombre.IsChecked ? "Hombre" : "Mujer");

            critica = nombre + " es ";

            List<string> caracteristicas = new List<string>();

            // Verificar cada checkbox y agregar la característica correspondiente a la lista
            if (Alto.IsChecked)
                caracteristicas.Add("alto");
            if (Listo.IsChecked)
                caracteristicas.Add("listo");
            if (Raro.IsChecked)
                caracteristicas.Add("raro");
            if (Feo.IsChecked)
                caracteristicas.Add("feo");
            if (Extravagante.IsChecked)
                caracteristicas.Add("extravagante");
            if (Grande.IsChecked)
                caracteristicas.Add("grande");

            // Cambiar la última letra de las características si el RadioButton "Mujer" está seleccionado
            if (genero == "Mujer")
            {
                for (int i = 0; i < caracteristicas.Count; i++)
                {
                    if (caracteristicas[i] != "extravagante" && caracteristicas[i] != "grande")
                    {
                        caracteristicas[i] = caracteristicas[i].Substring(0, caracteristicas[i].Length - 1) + "a";
                    }
                }
            }

            // Construir la cadena de crítica usando la lista de características
            for (int i = 0; i < caracteristicas.Count; i++)
            {
                critica += caracteristicas[i];

                if (i < caracteristicas.Count - 2)
                    critica += ", ";
                else if (i == caracteristicas.Count - 2)
                    critica += " y ";
            }

            critica += ".";

            Critica.Text = critica;
        }
    }
}

