using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class ScrollViewDemoPage : ContentPage
    {
        public ScrollViewDemoPage()
        {
            Title = "ScrollView";
            Label header = new Label
            {
                Text = "ScrollView",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
            };

            Label scrollText = new Label
            {
                Text = "Lorem ipsum dolor sit amet, eget eget aenean, in justo ad. Ac suspendisse ultrices, quis mauris volutpat, nostra nullam ornare ut posuere egestas, risus etiam a ut id. Morbi pede, etiam libero mauris amet. Vitae venenatis massa, aliquam lacus a fusce, in diam elementum eleifend, convallis nunc. At elit, elit aliquam nullam proin venenatis dui dui, sed lacus arcu lacus id quam. Tellus nec tristique purus, mollis wisi est erat rutrum vestibulum eleifend, pellentesque est orci id.\n\nPede auctor suscipit libero. Integer ultricies, sapien semper, aliquam cursus quis quis velit in. Cras tincidunt. Qui ligula et felis pede, eu elit adipiscing donec est. Etiam libero, mus proin enim voluptate est lorem turpis. Enim tincidunt vel. Neque libero per, turpis praesent sem adipiscing, commodo natoque aliquam, eget nibh aliquet arcu auctor arcu tellus, nunc wisi pede imperdiet.\n\nSed purus elementum elit non, lectus arcu mauris, eget mauris ac quisque quisque gravida in, a ornare aliquam. Elementum maecenas, velit quisque volutpat ut, adipiscing sociosqu feugiat mauris. Vivamus semper dictum donec nulla morbi at, consectetuer eget massa urna. Ante odio nulla, pulvinar id laoreet donec amet molestie, in odio felis eu. Praesent sit quis massa pretium, vel libero enim amet ante. Autem sed sollicitudin tincidunt congue ut nunc.\n\nNibh wisi. Quisque consectetuer urna sed nullam, nulla nullam urna convallis, placerat consectetuer gravida, habitasse imperdiet amet vel suspendisse tortor. Pede accumsan sem sit aenean gravida aliquam, aliquam aliquet pede rhoncus et nibh. Eget ipsum, ac mauris. Orci lacus, fermentum suspendisse enim odio morbi semper commodo, nonummy pulvinar dictum orci cras. Urna at ante sed mus nunc, sed sed at amet nunc, ultricies ac, vel vestibulum nam mollis sapien scelerisque, viverra eu montes nulla. Suspendisse wisi, justo volutpat nec ut, praesent quis nulla non amet dictum, libero pellentesque libero ut ut lacus etiam. Nec praesentium, vel in wisi felis consectetuer ac in. At proin gravida rutrum nec habitasse quis, placeat magna. Neque ligula mattis dolor lacinia. Integer cursus felis nec, nec ligula rhoncus sed ante sed, montes erat, eleifend sem aliquam, in nec sollicitudin magnis ut magnis quam.",
                VerticalOptions = LayoutOptions.StartAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };



            ScrollView scroll = new ScrollView
            {
                Content = scrollText

            };

            Content = new StackLayout
            {
                Padding = new Thickness(20),
                Children = {
                    header,
                    scroll,
                }
            };
        } //End constructor
    }
}
