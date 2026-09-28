using Layout.Pages;
using Microsoft.Maui.Controls;
using System;

namespace Layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Vertical_Clicked(object sender, EventArgs e)
        {
          await Navigation.PushAsync(new Pages.VerticalPage());
        }

        private async void Horizontal_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new Pages.HorizontalPage());
        }

        private async void Grid_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new Pages.GridPage());
        }

        private async void Flex_Clicked(object sender, EventArgs e)
        {
          await   Navigation.PushAsync(new Pages.FlexPage());
        }

        private async void Absolute_Clicked(object sender, EventArgs e)
        {
  await Navigation.PushAsync(new Pages.AbsolutePage());
        }
    }
}