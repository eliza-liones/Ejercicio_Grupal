namespace Ejercicio_Grupal;

public partial class EjercicioTres : ContentPage
{
	public EjercicioTres()
	{
		InitializeComponent();
	}
    private void OnTablaClicked(object sender, EventArgs e)
    {
        if (sender is Button boton && boton.CommandParameter is string numeroStr && int.TryParse(numeroStr, out int numero))
        {
            TituloTabla.Text = $"Tabla del {numero}";
            ListaResultados.Children.Clear();

            for (int i = 1; i <= 10; i++)
            {
                var label = new Label
                {
                    Text = $"{numero} x {i} = {numero * i}",
                    FontSize = 20,
                    TextColor = Colors.Black
                };
                ListaResultados.Children.Add(label);
            }
        }
    }
}