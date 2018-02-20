using System;
using DumbStock.RR.Views;
using Xamarin.Forms;

namespace DumbStock.RR
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page strategiesPage, aboutPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    strategiesPage = new NavigationPage(new StrategiesPage())
                    {
                        Title = "Browse"
                    };

                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "About"
                    };
                    strategiesPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";
                    break;
                default:
                    strategiesPage = new StrategiesPage()
                    {
                        Title = "Browse"
                    };

                    aboutPage = new AboutPage()
                    {
                        Title = "About"
                    };
                    break;
            }

            Children.Add(strategiesPage);
            Children.Add(aboutPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
