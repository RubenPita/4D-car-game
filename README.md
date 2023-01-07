# 4D Car Game

This is a project I made 6 years ago : https://www.youtube.com/watch?v=8WCwRnCh0zo&lc=UgxIbXtk8FHrrkHjGmp4AaABAg

I was pretty new to programming and even newer to electronics so I had to dig a bunch.

## Process :

1. In C#, in Unity, get speed value of car and send it through a virtual port
2. In an Arduino script, recover that value from the virtual port and send it to pin 9 (the value must be between 0 and 255)
3. Pin 9 will control the frequency of the fan through a transistor in the fan's circuit

Unfortunally I do not have the schematics for the electrical circuit anymore but it is really simple electronics. All I did was :

1. Cut the power cable of the fan and separate the positive and negative wires
2. Cut them both and plug them into the circuit board
3. Between either the negative or positive (I can't tell from the video) I plugged a transistor that is just gonna act as a gate. So if the gate is closed -> circuit closed -> fan no work
4. I plugged the third leg of the transistor to the 9th pin of the arduino
5. The 9th pin sends a digital output. If the car's speed is at 0, the pin will not send a signal so the gate/transistor will not open, so fan no work. If the car's speed is at about 128, the pin will send a signal half of the time (half of a hertz?), so the fan should turn at half the speed. And you can guess what happens at car's speed 255 and every other value. You can visually see this through the oscilloscope in the video
6. The last thing plugged in I'd guess is the oscilloscope, to monitor the frequency

## Notes :

- It's pretty much turning on and off the fan very fast
- I chose to send a digital signal over analogical because it would probably have burnt the fan, or worse
- There was no transformation of the car's speed value which led to the max speed only be attainable when I went off the map. Should've done better by multiplying the value
- After reading the arduino script I realised I call analogWrite() at the start of the loop. Doesn't matter too much but it should go at the end of the loop

---

I like lists.
