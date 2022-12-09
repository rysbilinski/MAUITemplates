namespace $rootnamespace$;

public partial class $safeitemname$ : BaseViewModelPage
{
	public $safeitemname$($PageName$ViewModel vm)
	{
		InitializeComponent();

		this.BindingContext = vm;
	}
}