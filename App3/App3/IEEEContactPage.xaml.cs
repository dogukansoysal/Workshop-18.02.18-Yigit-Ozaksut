using App3.Models;
using App3.Provider;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IEEEContactPage : ContentPage
	{
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        public IEEEContactPage ()
		{
			InitializeComponent ();
		}

        async void SendEmail(object sender, EventArgs e)
        {
            ServiceManager manager = new ServiceManager();
            var model = new IEEEContactModel
            {
                email = txtEmail.Text,
                name = txtNameSurname.Text,
                message = txtMessage.Text
            };

            var result = await manager.SendMessage(model);
            DisplayAlert("Sonuç", result, "Ok");
        }
    }
}