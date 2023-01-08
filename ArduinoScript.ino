int data = 0;
int pin = 9;
int strength = 0;

void setup() 
{
    Serial.begin(9600);
    Serial.setTimeout(10);
    pinMode(pin, OUTPUT);
}

void loop() 
{
    if (Serial.available())
    {
        data = Serial.parseInt();
        Serial.print(data); // debug

        if (data >= 0 || data <= 255)
        {
            strength = data;
        }
    }
  
    analogWrite(pin, strength);
}
