using Xamarin.Forms;

namespace App3
{
    public class IEEEMasterPage : MasterDetailPage
    {
        public IEEEMasterPage()
        {
            var myNavPage = new NavigationPage(new IEEEDetailPage())
            {
                BarBackgroundColor = Color.FromHex("#004a94"),
                BarTextColor = Color.FromHex("#fff")
            };

            Detail = myNavPage;
            Master = new IEEEMenuPage();
        }
    }
}