namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
  
        public MainPage(ProductViewModel productViewModel)
        {
            InitializeComponent();
            BindingContext = productViewModel;
        }

         
    }

}
