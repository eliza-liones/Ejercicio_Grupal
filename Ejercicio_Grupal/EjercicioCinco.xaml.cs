namespace Ejercicio_Grupal;

public partial class EjercicioCinco : ContentPage
{
	public EjercicioCinco()
	{
		InitializeComponent();
	}

    private void CalcularPresupuesto(object sender, EventArgs e)
    {
        // Validar que se ingres� un n�mero
        if (int.TryParse(txtPersonas.Text, out int personas))
        {
            double costoPorPersona;

            // Determinar el costo por persona seg�n el rango
            if (personas > 300)
            {
                costoPorPersona = 75.00;
            }
            else if (personas > 200)
            {
                costoPorPersona = 85.00;
            }
            else
            {
                costoPorPersona = 95.00;
            }

            // Calcular el total
            double total = personas * costoPorPersona;

            // Mostrar el resultado
            lblResultado.Text = $"N�mero de personas: {personas}\n" +
                                $"Costo por persona: ${costoPorPersona}\n" +
                                $"Presupuesto total: ${total}";
        }
        else
        {
            // Si no es un n�mero v�lido
            lblResultado.Text = "Por favor ingrese un n�mero v�lido.";
        }
    }
        
}