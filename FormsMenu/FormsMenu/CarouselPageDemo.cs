using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class CarouselPageDemo : CarouselPage
    {
        public CarouselPageDemo()
        {
            Children.Add(new ScrollViewDemoPage());
            Children.Add(new StopWatchAppPage());
            Children.Add(new SliderAndSwitchAppPage());
        }
    }
}
