using CommunityToolkit.Mvvm.ComponentModel;
using Percentaker.Models;
using System;
using System.Collections.Generic;
using System.Windows.Media;
using Wpf.Ui.Common.Interfaces;

namespace Percentaker.ViewModels
{
    public partial class DataViewModel : ObservableObject, INavigationAware
    {

        private bool _isInitialized = false;


        public void OnNavigatedTo()
        {
            if (!_isInitialized)
                InitializeViewModel();
        }

        public void OnNavigatedFrom()
        {
        }

        private void InitializeViewModel()
        {


            _isInitialized = true;
        }
    }
}
