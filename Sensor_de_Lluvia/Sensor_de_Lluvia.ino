const int rainSensorPin = 2;
const int buzzerPin = 11;
const int ledPin = 4;

void setup() {
  pinMode(rainSensorPin, INPUT);
  pinMode(buzzerPin, OUTPUT);
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  int rainSensorValue = digitalRead(rainSensorPin);

  // LOW = agua detectada → activar alarma
  if (rainSensorValue == LOW) { 
    digitalWrite(buzzerPin, HIGH); // ENCIENDE buzzer
    digitalWrite(ledPin, HIGH);    // ENCIENDE LED
  } else {
    digitalWrite(buzzerPin, LOW);  // APAGA buzzer
    digitalWrite(ledPin, LOW);     // APAGA LED
  }

  Serial.println(rainSensorValue);
  delay(1000);
}