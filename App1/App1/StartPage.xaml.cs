using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await DisplayAlert("Registrate","You create accont","OK");
        }
    }
}