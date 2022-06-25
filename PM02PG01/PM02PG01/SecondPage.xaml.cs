
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02PG01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage(decimal Resultado)
        {
            InitializeComponent();
            Lbresultado.Text = Resultado.ToString();
        }
    }
}