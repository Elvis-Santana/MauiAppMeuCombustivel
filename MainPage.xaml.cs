namespace MauiAppMeuCombustivel;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			double etanl = Convert.ToDouble(txt_etanol.Text);
            double gasolina = Convert.ToDouble(txt_gasolina.Text);

			string msg = "";

			if (etanl <= (gasolina * 0.7))
				msg = "O etanol está compoensando.";
			else
				msg = "O gasolina está compoensando.";

			DisplayAlert("Calculado",msg,"Ok");
            
			

        }
        catch (Exception ex)
		{
			DisplayAlert("Ops",ex.Message,"Fechar");
		}
    }
}

