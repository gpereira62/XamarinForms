using System;
using Xamarin.Forms;

namespace XamarinFormsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGreetButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameEntry.Text))
            {
                GreetingLabel.Text = "Please enter your name first!";
                return;
            }

            GreetingLabel.Text = $"Hello, {NameEntry.Text}!";
        }
    }
}