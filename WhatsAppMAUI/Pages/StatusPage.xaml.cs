

using Microsoft.Maui.Controls;

namespace WhatsAppMAUI.Pages
{
    using System.Collections.ObjectModel;
    using System.Security.Cryptography.X509Certificates;
    //public partial class StatusPage : ContentPage
    //{
    //    public StatusPage()
    //    {
    //        InitializeComponent();

    //        // Simulación de datos para la lista de estados (reemplázalo con tus propios datos)
    //        estadosListView.ItemsSource = new[]
    //        {
    //            new { Text = "Estado 1" },
    //            new { Text = "Estado 2" },
    //            new { Text = "Estado 3" },
    //            new { Text = "Estado 4" }


    //        };
    //    }

    //    private void EnviarButton_Click(object sender, EventArgs e)
    //    {
    //        // Lógica para manejar el envío del estado
    //        var nuevoEstado = estadoTextBox.Text;
    //        // Agrega el nuevo estado a la lista o realiza las acciones necesarias
    //        // ...

    //        // Limpia el cuadro de texto después de enviar
    //        estadoTextBox.Text = string.Empty;
    //    }
    //}
    using WhatsAppMAUI.Models;



    public partial class StatusPage : ContentPage
    {
        public ObservableCollection<Estado> Estados { get; set; }

        public StatusPage()
        {
            InitializeComponent();

            Estados = new ObservableCollection<Estado>
            {
                new Estado { Nombre = "Mi estado", Imagen = "avatar.png", Hora = "11:42 a. m." },
                new Estado { Nombre = "Monchy", Imagen = "avatar.jpg", Hora = "hace 7 minutos" },
                new Estado { Nombre = "Andrés Mecánico", Imagen = "avatar.jpg", Hora = "hace 15 minutos" },
                new Estado { Nombre = "Sobrina De Ovier", Imagen = "avatar.jpg", Hora = "hace 18 minutos" },
                // ...
            };

            BindingContext = this;

         
            Content = new StackLayout
            {
                Children =
                {
                    new ListView
                    {
                        ItemsSource = Estados,
                        ItemTemplate = new DataTemplate(() =>
                        {
                            var image = new Image { WidthRequest = 50, HeightRequest = 50 };
                            image.SetBinding(Image.SourceProperty, "Imagen");

                            var nombreLabel = new Label();
                            nombreLabel.SetBinding(Label.TextProperty, "Nombre");

                            var horaLabel = new Label();
                            horaLabel.SetBinding(Label.TextProperty, "Hora");

                            return new ViewCell
                            {
                                View = new StackLayout
                                {
                                    Orientation = StackOrientation.Horizontal,
                                    Children = { image, new StackLayout { Children = { nombreLabel, horaLabel } } }
                                }
                            };
                        })
                    },
                }
            };
        }

        private void EnviarButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Puedes agregar aquí la lógica para enviar el estado o realizar alguna acción específica

                // Muestra un mensaje de éxito
                DisplayAlert("Éxito", "Estado enviado correctamente", "Aceptar");
            }
            catch (Exception ex)
            {
                // Manejo de errores: Puedes agregar lógica para manejar errores aquí
                DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "Aceptar");
            }
        }

        public class Estado
        {
            public string Nombre { get; set; }
            public string Imagen { get; set; }
            public string Hora { get; set; }
        }
    }

}






