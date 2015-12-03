using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class App : Application
    {
        int clickTotal = 0;

        Label label1 = new Label
        {
            XAlign = TextAlignment.Center,
            Text = "0 click"
        };

        Button myButton = new Button
        {
            Text = "Click me to count up"
        };

        Stepper myStepper = new Stepper
        {
            Value = 1,
            Minimum = 1,
            Maximum = 10,
            Increment = 1,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

            Slider mySlider = new Slider
            {
                Maximum = 100
            };

        Label label2 = new Label
        {
            XAlign = TextAlignment.Center,
            Text = "0"
        };
        public App()
        {
            myButton.Clicked += OnButtonClicked;

            mySlider.ValueChanged += OnSliderValueChanged;

            //myStepper.ValueChanged += OnStepperValueChanged;

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {

                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        label1,
                        myButton,
                        myStepper,
                        mySlider,                       
                        label2
                    }
                }
            };
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            label2.Text = mySlider.Value.ToString();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            clickTotal += (int)myStepper.Value;
            label1.Text = String.Format("{0} button click{1}",
                          clickTotal, clickTotal == 1 ? "" : "s");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
