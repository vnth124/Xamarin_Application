using System;
using Xamarin.Forms;

namespace MyAppPolicy
{
    public partial class MainPage : ContentPage
    {
        bool m_BtnClicked;
        public MainPage()
        {
            InitializeComponent();
        }
       
        protected override void OnAppearing()
        {
            m_BtnClicked = false;
        }
        private void TapGestureRecognizer_Tapped(object sender,EventArgs e)
        {
            {

                if (!m_BtnClicked)
                {
                    m_BtnClicked = true;
                    Navigation.PushModalAsync(new MyPolicies());

                }
                else
                {
                    m_BtnClicked = false;
                }
            }
        }

    }
}
