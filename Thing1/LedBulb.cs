using System;
using Windows.UI;
using Windows.Devices.Gpio;

namespace org.jrj.RPi.Thing1
{ 
    /// <summary>
    /// A controll class for an LED bulb connected to a GPIO pin
    /// </summary>
    class LedBulb
    {
        private GpioPin pin;
        private GpioPinValue pinValue;
        private GpioController gpio;

        /// <summary>
        /// Initializes the LED so it can be used. Needs to be done at application launch.
        /// </summary>
        public void Initialize()
        {
            this.gpio = GpioController.GetDefault();

            //TODO - Need to handle case where GPIO not found if (gpio == null)

            this.pin = gpio.OpenPin(this.PinNumber);
            this.pinValue = GpioPinValue.Low;
            this.pin.Write(pinValue);
            this.pin.SetDriveMode(GpioPinDriveMode.Output);
            this.ison = false;

            return;
        }

        /// <summary>
        /// Turns the LED on at full power
        /// </summary>
        public void TurnOn()
        {
            this.pinValue = GpioPinValue.High;
            this.pin.Write(pinValue);
            this.pin.SetDriveMode(GpioPinDriveMode.Output);
            this.ison = true;

            return;
        }

        /// <summary>
        /// Turns the LED off
        /// </summary>
        public void TurnOff()
        {
            this.pinValue = GpioPinValue.Low;
            this.pin.Write(pinValue);
            this.pin.SetDriveMode(GpioPinDriveMode.Output);
            this.ison = false;
            
            return;
        }

        /// <summary>
        /// Toggles the LED (If on, turns off. If off, turns on.)
        /// </summary>
        public void Toggle()
        {
            if (this.isOn)
            {
                this.TurnOff();
            }
            else
            {
                this.TurnOn();
            }
            return;
        }


        /// <summary>
        /// Is the bulb currently lit?
        /// </summary>
        public bool isOn
        {
            get
            {
                return ison;
            }
        }
        private bool ison = false;

        /// <summary>
        /// The color of the bulb.
        /// </summary>
        public Windows.UI.Color Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
                return;
            }
        }
        private Windows.UI.Color color;

        /// <summary>
        /// The pin number the bulb is connected to on the GPIO bus
        /// </summary>
        public int PinNumber
        {
            get
            {
                return pinNumber;
            }

            set
            {
                pinNumber = value;
                return;
            }
        }
        private int pinNumber;
    }

    //TODO add event handler for change
}
