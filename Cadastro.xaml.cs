namespace Projeto1;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();
	}

    private void btnCadastra_Clicked(object sender, EventArgs e)
    {
		
    }

    private void txtCSenha_Completed(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCSenha.Text) || string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrEmpty(txtNUsuario.Text) || string.IsNullOrEmpty(txtEmail.Text))
        {
            DisplayAlert("Atenção", "Preencha todos os campos!", "OK");
        }
        else
        {
            btnCadastra.IsEnabled = true;

        }
    }
}