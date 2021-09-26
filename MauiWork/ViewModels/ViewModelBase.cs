using MauiWork.Helpers;
using MauiWork.Services;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiWork.ViewModels
{
    public class ViewModelBase : BindableObject
    {
        ICommand clickedCommand;
        public ICommand ClickedCommand => clickedCommand ??= new Command(IncrementCount);

        private void IncrementCount()
        {
            Random rnd = new Random();

            ThemeSettings.Theme = rnd.Next(0, 2);

            System.Diagnostics.Debug.WriteLine($"{ThemeSettings.Theme}");

            ThemeSettings.SetTheme();

            IToast service = DependencyService.Get<IToast>();
            System.Diagnostics.Debug.WriteLine(service.MakeToast());

        }

        private int count = 0;
        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged();
            }
        }

    }
}
