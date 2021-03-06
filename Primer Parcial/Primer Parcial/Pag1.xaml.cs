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
    public partial class Pag1 : ContentPage
    {
        public Pag1()
        {
            InitializeComponent();
        }

        private void btnCal_Clicked(object sender, EventArgs e)
        {

            int num1 = Int32.Parse(ingdato.Text);
            int rst = 0;
            rst = num1 - 365;
            string calc = rst + "";
            string porc = calc.Substring(0, 2);
            string res = calc.Substring(2, 2);
            string total = "Usted nacio el dia " + porc + " Usted nacio el mes " + res;
            lblRes1.Text = total + "";

        }
    }
}