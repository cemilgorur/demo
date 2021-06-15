using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proje.Master
{
    public class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            Master = new MyMenu();
            Detail = new NavigationPage(new MyDetail());
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            IsPresented = false;
        }
      
    }
}