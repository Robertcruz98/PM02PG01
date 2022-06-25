using System;
using Xamarin.Forms;

namespace PM02PG01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);
            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(num1 + num2)));

            //await DisplayAlert("Suma", Convert.ToString(num1+num2), "OK");
        }

        private async void btnrestar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);
            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(num1 - num2)));
        }

        private async void btndividir_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);
            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(num1 / num2)));
        }

        private async void btnmultiplicar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);
            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(num1 * num2)));
        }

        /* private async void btnsegunda_Clicked(object sender, EventArgs e)
         {
             await Navigation.PushAsync(new SecondPage());

         }*/
    }
}
