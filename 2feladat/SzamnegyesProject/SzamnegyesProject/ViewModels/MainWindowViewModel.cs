using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SzamnegyesProject.Models;

namespace SzamnegyesProject.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private int a;
        [ObservableProperty]
        private int b;
        [ObservableProperty]
        private int c;
        [ObservableProperty]
        private int d;
        [ObservableProperty]
        private int e;
        [ObservableProperty]
        private int f;
        [ObservableProperty]
        private int g;
        [ObservableProperty]
        private int h;
        [ObservableProperty]
        private int i;


        public MainWindowViewModel()
        {
        }

        [RelayCommand]
        public void IncreaseTableA()
        {
            A++;
            B++;
            D++;
            E++;
        }

        [RelayCommand]
        public void IncreaseTableB()
        {
            B++;
            C++;
            E++;
            F++;
        }

        [RelayCommand]
        public void IncreaseTableC()
        {
            D++;
            E++;
            G++;
            H++;
        }

        [RelayCommand]
        public void IncreaseTableD()
        {
            E++;
            F++;
            H++;
            I++;
        }

        [RelayCommand]
        public void Nullaz()
        {
            A=0; B=0; C=0; D=0; E=0; F=0; G=0; H=0;
        }
    }
}
