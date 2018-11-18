﻿using System.Reactive.Disposables;
using DryIocAttributes;
using Medium.Core.Interfaces;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Medium.Core.ViewModels
{
    [Reuse(ReuseType.Singleton)]
    [ExportEx(typeof(MainPageViewModel))]
    public sealed class MainPageViewModel : ReactiveObject, ISupportsActivation
    {
        public ViewModelActivator Activator { get; }
            
        [Reactive] public bool UserProfilePopUpIsOpen { get; set; }

        public MainPageViewModel(
            INavigationService navigationService)
        {
            Activator = new ViewModelActivator();
            this.WhenActivated(disposables =>
            {
                // Example disposition logic.
                Disposable.Create(() => {}).DisposeWith(disposables);
            });

            ShowPopUpCommand = ReactiveCommand.Create(() => { UserProfilePopUpIsOpen = !UserProfilePopUpIsOpen; });
        }

        public ReactiveCommand ShowPopUpCommand { get; private set; }
    }
}
