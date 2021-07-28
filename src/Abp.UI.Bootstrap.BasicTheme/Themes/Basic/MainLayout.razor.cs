using System;
using System.Collections.Generic;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Volo.Abp.UI.Navigation;

namespace Abp.UI.Bootstrap.BasicTheme.Themes.Basic
{
    public partial class MainLayout : IDisposable
    {
        [Inject]
        public IMenuManager MenuManager { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

 
        private Dictionary<string, string> TabItemTextDictionary { get; set; }
        private bool UseTabSet { get; set; } = true;

        private string Theme { get; set; } = "";

        private bool IsOpen { get; set; }

        private bool IsFixedHeader { get; set; } = true;

        private bool IsFixedFooter { get; set; } = true;

        private bool IsFullSide { get; set; } = true;

        private bool ShowFooter { get; set; } = true;
        private List<MenuItem> Menus { get; set; } = new List<MenuItem>();

        protected override void OnInitialized()
        {
           // NavigationManager.LocationChanged += OnLocationChanged;
        }

       
        public void Dispose()
        {
          //  NavigationManager.LocationChanged -= OnLocationChanged;
        }

    
    }
}
