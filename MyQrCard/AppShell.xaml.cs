using MyQrCard.View;

namespace MyQrCard;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("EmailPage", typeof(EmailPage));
	}
}