using App3.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IEEEDetailPage : ContentPage
	{
		public IEEEDetailPage ()
		{
			InitializeComponent ();
            this.Title = "Yaşar IEEE";

            BindData();
		}

        void BindData()
        {
            List<IEEEDetailModel> myModel = new List<IEEEDetailModel>();

            myModel.Add(new IEEEDetailModel
            {
                Id = 1,
                Count = "9",
                IconUrl = "handshake.png",
                Text = "Yıllık Tecrübe"
            });
            myModel.Add(new IEEEDetailModel
            {
                Id = 2,
                Count = "350",
                IconUrl = "teamwork.png",
                Text = "Üye"
            });
            myModel.Add(new IEEEDetailModel
            {
                Id = 3,
                Count = "~",
                IconUrl = "idcard.png",
                Text = "Etkinlik"
            });

            myLstView.ItemsSource = myModel;
        }
	}
}