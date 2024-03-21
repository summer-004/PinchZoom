namespace PinchZoom;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
        var webView = new WebView();
        webView.Source = "https://www.WEBSITE.com/";
        webView.UserAgent = "App" + DeviceInfo.Manufacturer + " " + DeviceInfo.Platform;
        Content = webView;
        InitializeComponent();
	}
}