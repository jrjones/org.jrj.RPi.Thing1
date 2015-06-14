# org.jrj.RPi.Thing1

This is a playground for experimenting with the Raspberry Pi + Windows 10 IoT. 

## Phase 1: Basic LEDs

The initial project is to create some classes for controlling LED bulbs. 

The 'LedBulb' class is a basic LED bulb-- you specify the pin that it's connected to, and you can use methods to turn the bulb on and off, etc.

            RedBulb.Color = Colors.Red;
            RedBulb.PinNumber = 5;
            RedBulb.Initialize();
            RedBulb.TurnOn();

The 'LedBulbRgb' class extends 'LedBulb' and adds functionality to controlling a multi-pin RGB LED bulb. Initially, it will just allow you to light up in red, green, or blue. However, in the future I will enable you to specify an arbitrary RGB value (example: #FF00FF) but first I have to get pulse width modulation working.

The 'MainPage' of the Thing1 app gives you three buttons for turning each of three LED bulbs on and off. It has a green bulb on GPIO pin 12, a red bulb on pin 5, and a blue bulb on pin 6.
