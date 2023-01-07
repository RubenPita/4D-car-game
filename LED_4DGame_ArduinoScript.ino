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
  analogWrite(pin, strength);
  
  if (Serial.available())
  {
    data = Serial.parseInt();
    Serial.print(data);

    if (data <= 255 || data >= 0)
    {
        strength = data;
    }
  }
}
