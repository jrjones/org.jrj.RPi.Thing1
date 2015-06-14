using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

/*  Thing1 is a quick hello world app for Raspberry Pi. Right now, it's not doing anything interesting.
    jrj@jrj.org

    (Item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409)
*/

namespace org.jrj.RPi.Thing1
{
    /// <summary>
    /// This is the main form for the app, shows a couple of software "lights" and buttons linked to the coresponding LEDs
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private LedBulb RedBulb = new LedBulb();
        private LedBulb GreenBulb = new LedBulb();
        private LedBulb BlueBulb = new LedBulb();

        // We will use these brushes to color the software lights
        private SolidColorBrush redBrush = new SolidColorBrush(Windows.UI.Colors.Red);
        private SolidColorBrush greenBrush = new SolidColorBrush(Windows.UI.Colors.Green);
        private SolidColorBrush grayBrush = new SolidColorBrush(Windows.UI.Colors.Gray);

        public MainPage()
        {
            this.InitializeComponent();

            GreenBulb.Color = Colors.Green;
            GreenBulb.PinNumber = 12;
            GreenBulb.Initialize();
            GreenBulb.TurnOn();

            RedBulb.Color = Colors.Red;
            RedBulb.PinNumber = 5;
            RedBulb.Initialize();
            RedBulb.TurnOn();

            BlueBulb.Color = Colors.Blue;
            BlueBulb.PinNumber = 6;
            BlueBulb.Initialize();
            BlueBulb.TurnOn();
        }

        private void ButtonLEDRed_Click(object sender, RoutedEventArgs e)
        {
            if (this.RedBulb.isOn)
            {
                this.LED_R.Fill = new SolidColorBrush(RedBulb.Color);
            }
            else
            {
                this.LED_R.Fill = grayBrush;
            }
            this.RedBulb.Toggle();
        }
        
        private void ButtonLEDGreen_Click(object sender, RoutedEventArgs e)
        {
            if (this.GreenBulb.isOn)
            {
                this.LED_G.Fill = new SolidColorBrush(GreenBulb.Color);
            }
            else
            {
                this.LED_G.Fill = grayBrush;
            }
            this.GreenBulb.Toggle();
        }

        private void ButtonLEDBlue_Click(object sender, RoutedEventArgs e)
        {
            if (this.BlueBulb.isOn)
            {
                this.LED_B.Fill = new SolidColorBrush(BlueBulb.Color);
            }
            else
            {
                this.LED_B.Fill = grayBrush;
            }
            this.BlueBulb.Toggle();
        }
    }
}
