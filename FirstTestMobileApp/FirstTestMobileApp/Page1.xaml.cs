using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstTestMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        int cout;
        public Page1()
        {
            InitializeComponent();

        }
        
        private void ButtonEntry1(object sender,EventArgs e)
        {
            Label1.Text = Entry1.Text;
        }
        private void ButtonClick1(object sender, EventArgs e)
        {
            cout++;
            string coutext = Convert.ToString(cout);
            Score.Text = coutext;
            if (cout == 50)
            {
                Label labelHide1 = new Label
                {   Text = "Have a nice day :)", 
                    FontSize = 30,
                    VerticalOptions = LayoutOptions.Center, 
                    HorizontalOptions = LayoutOptions.Center ,
                    TextColor = Color.FromHex("#00FF00") 
                };
                main.Children.Add(labelHide1);
            }

        }

    }
}