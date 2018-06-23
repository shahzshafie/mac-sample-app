using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using XFMacApp.Abstractionlayer.Services;
using Xamarin.Forms;

namespace XFMacApp
{
    public class MainPageViewModel : ViewModelBase
    {
        private ICommand _openCommand;

        public MainPageViewModel()
        {
        }

        public ICommand OpenDialogCommand
        {
            get { return _openCommand ?? (_openCommand = new RelayCommand(OpenDialog)); }
        }

        private void OpenDialog()
        {
            var dialogService = DependencyService.Get<IFileDialogService>();
            dialogService.Open();
        }
    }
}
