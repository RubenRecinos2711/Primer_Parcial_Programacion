using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Primer_Parcial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Inicializar();
            {

                btnpag1.Clicked += Btnpag1_Clicked;
                btnpag2.Clicked += Btnpag2_Clicked;

            }

        }

        private void Btnpag2_Clicked(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new Pag2());

        }

        private void Btnpag1_Clicked(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new Pag1());

        }

        private void Inicializar()
        {
            


        }
    }
}
