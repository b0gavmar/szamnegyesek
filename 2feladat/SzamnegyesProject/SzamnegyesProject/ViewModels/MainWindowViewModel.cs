using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SzamnegyesProject.Models;

namespace SzamnegyesProject.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private Szamnegyes a;
        [ObservableProperty]
        private Szamnegyes b;
        [ObservableProperty]
        private Szamnegyes c;
        [ObservableProperty]
        private Szamnegyes d;

        public MainWindowViewModel()
        {
            A = new Szamnegyes();
            B = new Szamnegyes();
            C = new Szamnegyes();
            D = new Szamnegyes();
        }

        [RelayCommand]
        public void IncreaseTableA()
        {
            A.Increase(1);
        }

        [RelayCommand]
        public void IncreaseTableB()
        {
            B.Increase(2);
        }

        [RelayCommand]
        public void IncreaseTableC()
        {
            C.Increase(3);
        }

        [RelayCommand]
        public void IncreaseTableD()
        {
            D.Increase(4);
        }
    }
}
