namespace Ejercicio_Grupal;

public partial class EjercicioDos : ContentPage
{

    int contador = 10;
    IDispatcherTimer timer;


    public EjercicioDos()
	{
		InitializeComponent();

        // Configuración del temporizador
        timer = Application.Current.Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += Timer_Tick;
    }


    private void Iniciar_Clicked(object sender, EventArgs e)
    {
        contador = 10;
        lblCuenta.Text = contador.ToString();
        btnIniciar.IsEnabled = false;
        timer.Start();
    }

    private async void Timer_Tick(object sender, EventArgs e)
    {
        contador--;
        lblCuenta.Text = contador.ToString();

        if (contador == 0)
        {
            timer.Stop();
            btnIniciar.IsEnabled = true;

            // Mostrar alerta de finalización
            await DisplayAlert("Cuenta regresiva", "¡Tiempo terminado!", "OK");
            lblCuenta.Text = "10";
        }
    }
}