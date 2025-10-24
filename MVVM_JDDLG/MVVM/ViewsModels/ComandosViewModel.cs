using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_JDDLG.MVVM.ViewsModels
{
    public class ComandosViewModel
    {
        public ICommand ClickCommand { get; }

        public ComandosViewModel() 
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Título", "Mensaje", "Aceptar");
            });

        }

        private void Alert()
        {
        } 
    }
}
