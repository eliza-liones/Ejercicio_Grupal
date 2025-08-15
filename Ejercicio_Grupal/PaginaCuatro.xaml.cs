namespace Ejercicio_Grupal;

public partial class PaginaCuatro : ContentPage
{
	public PaginaCuatro()
	{
		InitializeComponent();
	}

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        bool horasValidas = double.TryParse(HorasEntry.Text, out double horas);
        bool pagoValido = double.TryParse(PagoEntry.Text, out double pagoPorHora);

        if (!horasValidas || !pagoValido)
        {
            ResultadoLabel.Text = "Por favor ingresa valores válidos.";
            return;
        }

        double sueldo = horas * pagoPorHora;
        ResultadoLabel.Text = $"Sueldo semanal: ${sueldo:F2}";
    }


}
