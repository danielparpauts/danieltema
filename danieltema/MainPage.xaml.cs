using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace danieltema
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("ma.jpg");
            AboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.audi);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }
        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "AUDI",
                Detail = "Lühike info",
                ImagePath = "aud.png",
                TargetPage = typeof(Views.audi)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "BMW",
                Detail = "Natuke rohkem minu kogemisest",
                ImagePath = "bmv.png",
                TargetPage = typeof(Views.bmw)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Mercedes",
                Detail = "Natuke rohkem minu oskustest",
                ImagePath = "mer.png",
                TargetPage = typeof(Views.mercedes)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Volkswagen",
                Detail = "Ma olen uhke!!!",
                ImagePath = "vols.png",
                TargetPage = typeof(Views.Volkswagen)
            });
            return list;

        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;

        }
    }
}
