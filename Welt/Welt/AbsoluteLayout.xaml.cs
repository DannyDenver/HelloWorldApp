using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Welt
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AbsoluteLayout : ContentPage
	{
		public AbsoluteLayout ()
		{
			InitializeComponent();

            //AbsoluteLayout layout = new AbsoluteLayout();
            //Content = layout;

            //var aquaBox = new BoxView { Color = Color.Aqua, VerticalOptions= LayoutOptions.FillAndExpand };
            //layout.Children.Add(aquaBox,
            //                new Rectangle(0, 0, 1, 1)
            //                , AbsoluteLayoutFlags.All);
            //AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectagle(0, 0, 1, 1));
            //AbsoluteLayout.SetLayoutBounds(aquaBox, AbsoluteLayoutFlags.HeightProportional);
        }
    }
}