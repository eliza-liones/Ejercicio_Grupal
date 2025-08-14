namespace Ejercicio_Grupal;

public partial class EjercicioUno : ContentPage
{
    public EjercicioUno()
    {
        InitializeComponent();
        MostrarNumerosPares();
    }

    private void MostrarNumerosPares()
    {
        int columnas = 4; // Cantidad de columnas
        int fila = 0;
        int columna = 0;

        // Colores pasteles para alternar
        string[] colores = { "#FFD6E0", "#D6F5FF", "#FFF5D6", "#D6FFD6", "#EAD6FF" };

        // Ajustar columnas en Grid
        for (int c = 0; c < columnas; c++)
            paresGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

        // Agregar números pares
        for (int i = 0; i <= 100; i += 2)
        {
            var etiqueta = new Label
            {
                Text = i.ToString(),
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                BackgroundColor = Color.FromArgb(colores[(i / 2) % colores.Length]),
                TextColor = Colors.Black
            };

            var marco = new Frame
            {
                Content = etiqueta,
                Padding = 0,
                CornerRadius = 15,
                HasShadow = true,
                BackgroundColor = Color.FromArgb(colores[(i / 2) % colores.Length]),
                HeightRequest = 60,
                WidthRequest = 60
            };

            paresGrid.Add(marco, columna, fila);

            columna++;
            if (columna >= columnas)
            {
                columna = 0;
                fila++;
                paresGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            }
        }
    }
}