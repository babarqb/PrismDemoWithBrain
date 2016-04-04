using Prism.Mvvm;

namespace PrismModuleA.ViewModels
{
    public class ToolbarViewModel : BindableBase
    {
        private string _toolbar ="Main Toolbar";
        public string ToolBar
        {
            get { return _toolbar; }
            set { SetProperty(ref _toolbar, value); }
        }
    }
}