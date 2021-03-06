using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Primer_Parcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pag2 : ContentPage
    {
        public Pag2()
        {
            InitializeComponent();
        }

        private void btnmag_Clicked(object sender, EventArgs e)
        {

            int parse1 = Int32.Parse(ingRes1.Text);
            int dividir, resta;
            dividir = parse1 / 10;
            resta = dividir - 4;
            lblRes2.Text = resta + "";

        }
    }
}