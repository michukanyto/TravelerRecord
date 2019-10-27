using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TraverlerRecord
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LogInButtonClicked(Object sender, EventArgs e)
        {
            bool user = string.IsNullOrEmpty(userEntry.Text);
            bool password = string.IsNullOrEmpty(passwordEntry.Text);

            if (user || password)
            {
                
            }
            else
            {
                LogIn logIn = new LogIn(userEntry.Text, passwordEntry.Text);
                bool logInIsCorrect = logIn.CheckLogIn();
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
