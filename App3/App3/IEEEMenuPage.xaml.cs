using App3.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IEEEMenuPage : ContentPage
	{
		public IEEEMenuPage ()
		{
			InitializeComponent ();
            BindData();
		}

        void BindData()
        {
            List<IEEEMenuModel> myModel = new List<IEEEMenuModel>();
            myModel.Add(new IEEEMenuModel
            {
                Id = 1,
                Text = "Anasayfa"
            });
            myModel.Add(new IEEEMenuModel
            {
                Id = 2,
                Text = "Hakkımızda"
            });
            myModel.Add(new IEEEMenuModel
            {
                Id = 3,
                Text = "Etkinliklerimiz"
            });
            myModel.Add(new IEEEMenuModel
            {
                Id = 4,
                Text = "İletişim"
            });
            myLstView.ItemsSource = myModel;
            //this.BindingContext = myModel;
            //myLstView.BindingContext = myModel
        }

        void OnMyItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = (IEEEMenuModel)e.SelectedItem;
            if (selectedItem.Text == "İletişim")
            {
                var master = (IEEEMasterPage)this.Parent;
                master.Detail = new NavigationPage(new IEEEContactPage());
                master.IsPresented = false;
            }
            else
            {
                DisplayAlert(selectedItem.Id.ToString(), selectedItem.Text, "Ok");
            }
        }
    }
}