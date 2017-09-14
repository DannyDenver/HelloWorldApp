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
    public partial class QuotesPage : ContentPage
    {
        int index = 0; 
        string[] quotes = new string[] { "You get smarter, when you eat brocolli.", "Brush your teeth twice a day", "Dont drink coffee past 4" };
        public  QuotesPage()
        {
            InitializeComponent();
            label.Text = "Howdy yall";
        }

        void Change_Quote(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            if(index == quotes.Length)
            {
                index = 0;
                label.Text = quotes[index];
            }
            else
            {
                label.Text = quotes[index];
                index = index + 1;
            }
        }

    }
}