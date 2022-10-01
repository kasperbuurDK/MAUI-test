namespace Notes.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
        BindingContext = new Models.About();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.About about) 
        {
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}

/*
<ContentPage.BindingContext>
        <models:About/>
    </ContentPage.BindingContext>
*/