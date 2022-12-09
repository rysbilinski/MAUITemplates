namespace $safeprojectname$.Views.Pages;

public partial class BaseViewModelPage : ContentPage
{
	public BaseViewModelPage()
	{
		InitializeComponent();
	}

    private bool firstAppearance = true;
    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (this.BindingContext is IPageLifeCycleAware vm)
            vm.OnAppearing(this, firstAppearance);

        firstAppearance = false;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (this.BindingContext is IPageLifeCycleAware vm)
            vm.OnNavigatedTo();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        if (this.BindingContext is IPageLifeCycleAware vm)
            vm.OnDisappearing(this);
    }
}