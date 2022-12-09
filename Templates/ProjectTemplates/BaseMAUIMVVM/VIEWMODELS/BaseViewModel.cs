using Refit;

namespace $safeprojectname$.ViewModels;

public partial class BaseViewModel : ObservableObject, IPageLifeCycleAware
{
    [ObservableProperty] private bool isLoading;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(NotBusy))]
    bool isBusy = false;
    public bool NotBusy => !IsBusy;
    [ObservableProperty] string title = string.Empty;


    public virtual void OnAppearing(object sender, bool firstAppearance)
    {
        this.PropertyChanged += BaseViewModel_PropertyChanged;
    }

    public virtual void OnNavigatedTo() { }

    private void BaseViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
    }

    public virtual void OnDisappearing(object sender)
    {
        this.PropertyChanged -= BaseViewModel_PropertyChanged;
    }


    protected Task ShowError(string title, string message) => ShowAlert(title, message);
    protected async Task ShowError(string title, Exception ex)
    {
        var message = ex.Message;

        if (ex is ApiException rex)
        {
            try
            {
                message = rex.Content;
            }
            catch (Exception parseContentEx)
            {
            }
        }

        await this.ShowError(title, message);
    }
    protected Task ShowError(Exception ex) => this.ShowError("Something went wrong", ex);
    protected Task ShowError(string message) => this.ShowError("Something went wrong", message);
    protected Task ShowAlert(string title, string message) => Shell.Current.DisplayAlert(title, message, "Ok");
    protected Task ShowSuccess(string message) => ShowAlert("Great Success", message);
}

public interface IPageLifeCycleAware
{
    void OnAppearing(object sender, bool firstAppearance);
    void OnNavigatedTo();
    void OnDisappearing(object sender);
}

