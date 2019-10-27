using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TraverlerRecord
{
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public void AddNewTravel(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewTravelPage());
        }

        public void ExitApp(Object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
