using System.Collections.ObjectModel;
using System.ComponentModel;
using WhatsAppMAUI.Models;

namespace WhatsAppMAUI.Pages;

public partial class ChatsPage : ContentPage, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    bool LoadingValue { get; set; }
    public bool Loading { get { return LoadingValue; } set
        {
            if(LoadingValue != value)
            {
                LoadingValue = value;
                OnPropertyChanged(nameof(Loading));
            }
        }
    }
    public Command OnRefresh { get; set; }
    ObservableCollection<ChatModel> Chats { get; set; }
    public ChatsPage()
	{
		InitializeComponent();
        Chats = new ObservableCollection<ChatModel>(LoadChats());

        OnRefresh = new Command(OnLoading);

        BindingContext = this;
	}

    protected override void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void OnLoading()
    {
        Loading = true;

        _ = DisplayAlert("Hola", "Mensaje", "Cancelar");

        Loading = false;
    }
}