using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wordul
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mainPage : ContentPage
    {
        public mainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void Settings_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Settings());
        }

        private void dailyWord_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Daily());
        }
    }
}