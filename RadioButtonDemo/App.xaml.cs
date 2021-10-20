using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RadioButtonDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "RadioButton_Experimental" });
            MainPage = new MainPage();
        }
    }
}