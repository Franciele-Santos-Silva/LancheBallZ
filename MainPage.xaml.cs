using System.Threading.Tasks;

namespace Projeto1
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Cadastar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cadastro());
        }
    }
}
