using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class TabbedPageDemo : TabbedPage
    {
        public TabbedPageDemo()
        {
            Children.Add(new ContactListPage());
            Children.Add(new StopWatchAppPage());
            Children.Add(new SliderAndSwitchAppPage());
            Children.Add(new StackLayoutDemoPage());
        }
    }
}
