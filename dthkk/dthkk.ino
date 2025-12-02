#include "DHT.h"

#define DHTPIN 6     // Pin digital donde está conectado el DHT11
#define DHTTYPE DHT11   // Tipo de sensor DHT11

DHT dht(DHTPIN, DHTTYPE);

void setup() {
    Serial.begin(9600);
    Serial.println("Iniciando sensor DHT11...");
    dht.begin();
}

void loop() {
    delay(2000); // Espera 2 segundos entre lecturas

    float h = dht.readHumidity();     // Leer humedad
    float t = dht.readTemperature();  // Leer temperatura en Celsius

    // Verificar si la lectura falló
    if (isnan(h) || isnan(t)) {
        Serial.println("Error al leer del sensor DHT11");
        return;
    }

    // Enviar datos en el formato que espera la aplicación C#
    Serial.print("Humedad: ");
    Serial.print(h);
    Serial.print(" %\t");
    Serial.print("Temperatura: ");
    Serial.print(t);
    Serial.println(" *C");
    
    // Formato alternativo por si el anterior no funciona:
    // Serial.print(h);
    // Serial.print("\t");
    // Serial.println(t);
}