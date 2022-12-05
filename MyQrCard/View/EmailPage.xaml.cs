using MyQrCard.ViewModel;

namespace MyQrCard.View;

public partial class EmailPage : ContentPage
{
    private string _email;
	public EmailPage(string email)
	{
        _email= email;
        InitializeComponent();
        BindingContext = new EmailPageViewModel(_email);
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}