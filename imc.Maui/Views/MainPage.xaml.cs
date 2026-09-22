using imc.Maui.Models;

namespace imc.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        SitucionNutricionalLabel.Text = string.Empty;
        ImcLabel.Text = string.Empty;
    }

    private void OnCalcularButtonClicked(object sender, EventArgs e)
    {
        decimal peso;
        decimal estatura;
        peso = decimal.Parse(PesoENtry.Text);
        estatura = decimal.Parse(EstaturaEntry.Text);
        decimal imc = Calculadoraimc.IndiceDeMasaCorporal(peso, estatura);
        ImcLabel.Text = imc.ToString("F4");
        SitucionNutricionalLabel.Text = Calculadoraimc.SituacionNutricional(imc);
        
    }

    private void OnLimpiarButtonClicked(object sender, EventArgs e)
    {
        PesoENtry.Text= string.Empty;
        EstaturaEntry.Text = string.Empty;
        SitucionNutricionalLabel.Text = string.Empty;
        ImcLabel.Text = string.Empty;


    }
}