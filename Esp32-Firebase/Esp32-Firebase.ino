#include <IOXhop_FirebaseESP32.h>
#include <WiFi.h>
#include <ArduinoJson.h>

#define FIREBASE_HOST "https://teste-esp32-e9fab-default-rtdb.firebaseio.com/"
#define FIREBASE_AUTH "GOZkxEqeE3F2hegEz13BxYhw9ZtA8DxWY3REwecC"

const char* WIFI_SSID = "Skm";
const char* WIFI_PASSWORD = "seujaowfx1";

const int SIGN = 14;
const int LED = 27;
String path = "ESP32/Valor";

void setup()
{
  Serial.begin(115200);
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);

  pinMode(SIGN, OUTPUT);
  pinMode(LED, OUTPUT);

  Serial.print("Conectando à rede");
  while(WiFi.status() != WL_CONNECTED)
  {
    Serial.print(".");
    delay(200);
  }
  Serial.println("\n\nConectado com sucesso à rede");
  Serial.print("Endereço IP: ");
  Serial.println(WiFi.localIP());
  digitalWrite(SIGN, true);

  Firebase.begin(FIREBASE_HOST, FIREBASE_AUTH);
}

void loop()
{
  while(WiFi.status() == WL_CONNECTED)
  {
    digitalWrite(LED, Firebase.getBool(path));    

    if(Firebase.failed())
    {
      Serial.println("Ocorreu um erro ao ler o valor do número.");
    }
  }

  if(WiFi.status() != WL_CONNECTED)
  {
    WiFi.begin(WIFI_SSID, WIFI_PASSWORD);

    pinMode(SIGN, false);
  
    Serial.print("Conectando à rede");
    while(WiFi.status() != WL_CONNECTED)
    {
      Serial.print(".");
      delay(200);
    }
    Serial.println("\n\nConectado com sucesso à rede");
    Serial.println("Endereço IP: " + WiFi.localIP());
    digitalWrite(SIGN, true);
  
    Firebase.begin(FIREBASE_HOST, FIREBASE_AUTH);
  }
}
