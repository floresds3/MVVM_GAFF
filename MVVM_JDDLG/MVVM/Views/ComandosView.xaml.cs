using MVVM_JDDLG.MVVM.ViewsModels;

namespace MVVM_JDDLG.MVVM.Views;

public partial class ComandosView : ContentPage
{
	public ComandosView()
	{
		InitializeComponent();

		BindingContext = new ComandosViewModel();
	}
}