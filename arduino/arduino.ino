//https://github.com/bentalebahmed/BlueUnity

int pot;


void setup() {
  Serial.begin(9600);
  pinMode(3,OUTPUT);
}

void loop() {
  pot = analogRead(A0);
  Serial.println(pot);
  delay(40);
    
}
void serialEvent()
{
  while(Serial.available()>0)
  {
    char caracterDeEntrada = Serial.read();
    if(caracterDeEntrada == 'a')
    {
        digitalWrite(3,HIGH);
        
      }
      if(caracterDeEntrada == 'b')
    {
        digitalWrite(3,LOW);
        
     }
    } 
 }
