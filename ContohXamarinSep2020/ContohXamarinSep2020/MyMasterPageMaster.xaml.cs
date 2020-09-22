using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContohXamarinSep2020
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterPageMaster : ContentPage
    {
        public ListView ListView;

        public MyMasterPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyMasterPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MyMasterPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyMasterPageMasterMenuItem> MenuItems { get; set; }

            public MyMasterPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyMasterPageMasterMenuItem>(new[]
                {
                    new MyMasterPageMasterMenuItem { Id = 0, Title = "Main Menu", TargetType=typeof(MainPage), ImageIcon="ic_add.png" },
                    new MyMasterPageMasterMenuItem { Id = 1, Title = "Image List", TargetType=typeof(BindingImage), ImageIcon="ic_add.png" },
                    new MyMasterPageMasterMenuItem { Id = 2, Title = "Custom List", TargetType=typeof(BindingToDataModel), ImageIcon="ic_add.png" },
                    new MyMasterPageMasterMenuItem { Id = 3, Title = "Tabbed Page",TargetType=typeof(MyTabbedPage), ImageIcon="ic_add.png" },
                    new MyMasterPageMasterMenuItem { Id = 4, Title = "Simple Calc", TargetType=typeof(ContohGridLayout), ImageIcon="ic_add.png" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}