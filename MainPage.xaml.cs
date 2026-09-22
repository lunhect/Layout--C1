

namespace Layout
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

     


        private void Vertical_Clicked(object sender, EventArgs e)
        {
        Navigation.PushAsync(new Pages.VerticalPage());
        }

        private void Horizontal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.HorizontalPage());
        }


        private void Grid_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Pages.GridPage());

        }

        private void Flex_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Pages.FlexPage());

        }

        private void Absolute_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new Pages.AbsolutePage());

        }

    }
}
