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
                MojaPage = typeof(Views.audi)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "BMW",
                Detail = "Natuke rohkem minu kogemisest",
                ImagePath = "bmv.png",
                MojaPage = typeof(Views.bmw)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Mercedes",
                Detail = "Natuke rohkem minu oskustest",
                ImagePath = "mer.png",
                MojaPage = typeof(Views.mercedes)

            });
            list.Add(new MasterMenuItems()
            {
                Text = "Volkswagen",
                Detail = "Ma olen uhke!!!",
                ImagePath = "vols.png",
                MojaPage = typeof(Views.Volkswagen)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Ford",
                Detail = "Ma olen uhke!!!",
                ImagePath = "fort.png",
                MojaPage = typeof(Views.Fort)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Lexus",
                Detail = "Ma olen uhke!!!",
                ImagePath = "leksus.png",
                MojaPage = typeof(Views.Lexus)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Mazda",
                Detail = "Ma olen uhke!!!",
                ImagePath = "maz.jpg",
                MojaPage = typeof(Views.Mazda)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Nissan",
                Detail = "Ma olen uhke!!!",
                ImagePath = "ni.png",
                MojaPage = typeof(Views.Nissan)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Subaru",
                Detail = "Ma olen uhke!!!",
                ImagePath = "subara.png",
                MojaPage = typeof(Views.Subaru)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Toyota",
                Detail = "Ma olen uhke!!!",
                ImagePath = "tojota.png",
                MojaPage = typeof(Views.Toyota)
            });
            return list;

        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.MojaPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;

        }
    }
}
