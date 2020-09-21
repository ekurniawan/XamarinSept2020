using ContohXamarinSep2020.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ContohXamarinSep2020.ViewModels
{
    public class BindingDataViewModel : BindableObject
    {
        public BindingDataViewModel()
        {
            lstItems = new List<ListItem>
            {
                new ListItem
                {
                    Title="Xamarin for Android",
                    Description = "Belajar Xamarin for Android"
                },
                new ListItem
                {
                    Title="Xamarin for IOS",
                    Description = "Belajar Xamarin for IOS"
                },
                new ListItem
                {
                    Title = "Xamarin Forms",
                    Description = "Belajar Xamarin Forms"
                }
            };
        }

        private List<ListItem> lstItems;
        public List<ListItem> ListItems
        {
            get { return lstItems; }
            set { lstItems = value; 
                OnPropertyChanged("ListItems"); }
        }

    }
}
