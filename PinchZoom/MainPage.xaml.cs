using Microsoft.Maui.Handlers;

namespace PinchZoom
{
    public partial class MainPage : ContentPage
    {
        public static bool flag = false;
        
        public int MyProperty { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            flag = !flag;
        }

        protected override void OnHandlerChanged()
        {
            base.OnHandlerChanged();
        }
    }
}
