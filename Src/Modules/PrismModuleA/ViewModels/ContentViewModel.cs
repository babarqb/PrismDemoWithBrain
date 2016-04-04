using Prism.Mvvm;

namespace PrismModuleA.ViewModels
{
    public class ContentViewModel : BindableBase
    {
        private string _firstName="Babar QB";
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }
    }
}