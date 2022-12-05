using MyQrCard.ViewModel;

namespace MyQrCard;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainPageViewModel();
        SizeChanged += MainPage_SizeChanged;
    }

    private void MainPage_SizeChanged(object sender, EventArgs e)
    {
        index.WidthRequest = Math.Min(300, 400);
    }
}

