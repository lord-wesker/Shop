namespace Shop.UIForms.Infrastructure
{
    using Shop.UIForms.ViewModels;

    public class InstaceLocator
    {
        public MainViewModel Main { get; set; }

        public InstaceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
