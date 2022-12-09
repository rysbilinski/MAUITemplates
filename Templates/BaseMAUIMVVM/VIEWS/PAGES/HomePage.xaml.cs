namespace $safeprojectname$.Views.Pages;

public partial class HomePage : BaseViewModelPage
{
	public HomePage(HomeViewModel vm)
	{
		InitializeComponent();

		this.BindingContext = vm;
	}
}