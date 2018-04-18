using System.Diagnostics;
using System.Windows.Input;
using Prism.Mvvm;
using Xamarin.Forms;

namespace EventToCommandApp
{
    public class MainPageViewModel : BindableBase
    {
        private ICommand navigatedCommand;

        public ICommand NavigatedCommand
        {
            get
            {
                if (this.navigatedCommand == null)
                {
                    this.navigatedCommand = new Command(url => { Debug.WriteLine(url); });
                }

                return this.navigatedCommand;
            }
        }
    }
}