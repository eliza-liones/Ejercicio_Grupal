namespace Ejercicio_Grupal;

public partial class EjercicioSeis : ContentPage
{

    private const decimal TipoDeCambio = 17.50m;
    public EjercicioSeis()
	{
		InitializeComponent();

	}
    private void Button_Clicked(object sender, EventArgs e)
    {

        // Obtener el valor del Entry
        if (decimal.TryParse(pesosEntry.Text, out decimal pesos))
        {
            // Realizar la conversión
            decimal dolares = pesos / TipoDeCambio;

            // Mostrar el resultado en el Label
            resultadoLabel.Text = $"{dolares:F2} USD";
        }
        else
        {
            // Manejar el caso en que el usuario introduzca un valor no numérico
            DisplayAlert("Error", "Por favor, introduce una cantidad válida.", "OK");
        }

    }
}