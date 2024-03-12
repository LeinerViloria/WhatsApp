using System.Collections.ObjectModel;

namespace WhatsAppMAUI.Pages;


    public partial class CallsPage : ContentPage
{
    public ObservableCollection<Llamada> Llamadas { get; set; }

    public CallsPage()
    {
        InitializeComponent();

        Llamadas = new ObservableCollection<Llamada>
            {
                new Llamada { Nombre = "Mi nombre", Imagen = "avatar.png", TipoLlamada = "Llamada de audio", Hora = "11:42 a. m." },
                new Llamada { Nombre = "Monchy", Imagen = "avatar.png", TipoLlamada = "Llamada de video", Hora = "hace 7 minutos" },
                new Llamada { Nombre = "Andrés Mecánico", Imagen = "avatar.png", TipoLlamada = "Llamada perdida", Hora = "hace 15 minutos" },
                new Llamada { Nombre = "Sobrina De Ovier", Imagen = "avatar.png", TipoLlamada = "Llamada de audio", Hora = "hace 18 minutos" },
                new Llamada { Nombre = "Magalis", Imagen = "avatar.png", TipoLlamada = "Llamada de audio", Hora = "hace 45 minutos" },
                // ...
            };

        BindingContext = this;
    }
}

public class Llamada
{
    public string Nombre { get; set; }
    public string Imagen { get; set; }
    public string TipoLlamada { get; set; }
    public string Hora { get; set; }


}
