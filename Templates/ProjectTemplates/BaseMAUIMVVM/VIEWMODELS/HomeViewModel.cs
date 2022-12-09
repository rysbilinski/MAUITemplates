namespace $safeprojectname$.ViewModels;

public class HomeViewModel : BaseViewModel
{
    private readonly INavigationService navigationService;

    public HomeViewModel(INavigationService navigationService)
	{
        this.navigationService = navigationService;
    }
}
