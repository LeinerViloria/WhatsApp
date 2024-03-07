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

    bool ShowArchivedsValue { get; set; }

    public bool ShowArchiveds
    {
        get { return ShowArchivedsValue; }
        set
        {
            if (ShowArchivedsValue != value)
            {
                ShowArchivedsValue = value;
                OnPropertyChanged(nameof(ShowArchiveds));
            }
        }
    }

    public Command OnRefresh { get; set; }
    public ObservableCollection<ChatModel> Chats { get; set; }

    int Skip { get; set; }
    int Take => 3;

    public ChatsPage()
	{
        Chats = new ObservableCollection<ChatModel>(LoadData(Skip, Take));

        OnRefresh = new Command(OnLoading);

        InitializeComponent();

        BindingContext = this;
	}

    protected override void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void OnLoading()
    {
        Loading = true;
        ShowArchiveds = true;

        var TotalToLoad = Chats.Count + Take;

        var Result = LoadData(TotalToLoad, 1).First();

        Chats.Add(Result);

        Loading = false;
    }

    public void ShowChats(object Sender, EventArgs e)
    {
        _ = DisplayAlert("Hola", "Se muestra el chat", "Cancelar");
    }
}