﻿using DryIocAttributes;
using Medium.Core.Services;
using ReactiveUI;
using Services.Interfaces.Interfaces;

namespace Medium.Core.ViewModels
{
    [Reuse(ReuseType.Singleton)]
    [ExportEx(typeof(MainPageViewModel))]
    public sealed class MainPageViewModel : ReactiveObject
    {
        private readonly IMediumApiService _mediumApiService;
        private readonly INavigationService _navigationService;

        public MainPageViewModel(IMediumApiService mediumApiService, INavigationService navigationService)
        {
            _mediumApiService = mediumApiService;
            _navigationService = navigationService;
        }
    }
}
