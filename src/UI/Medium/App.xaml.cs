﻿using Avalonia;
using Avalonia.Markup.Xaml;

namespace Medium
{
  
    public class App : Application
    {
        public App()
        {
        }

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
