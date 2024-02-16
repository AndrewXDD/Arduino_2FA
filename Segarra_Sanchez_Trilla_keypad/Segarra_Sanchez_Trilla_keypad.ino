#include <Wire.h>
#include <LCD.h>
#include <LiquidCrystal_I2C.h>
#include <Keypad.h>

LiquidCrystal_I2C lcd(0x27, 2, 1, 0, 4, 5, 6, 7);

const byte ROWS = 4;
const byte COLS = 4;

char hexaKeys[ROWS][COLS] = {
  { '1', '2', '3', 'A' },
  { '4', '5', '6', 'B' },
  { '7', '8', '9', 'C' },
  { '*', '0', '#', 'D' }
};

byte rowPins[ROWS] = { 9, 8, 7, 6 };
byte colPins[COLS] = { 5, 4, 3, 2 };

Keypad customKeypad = Keypad(makeKeymap(hexaKeys), rowPins, colPins, ROWS, COLS);

String password = "";
String input = "";
String inputString = "";

int temp = 58;
unsigned long previousMillis = 0;
const long interval = 1000;
bool done = false;
bool stringComplete = false;
bool waiting = false;
char inChar;

void setup() {
  Serial.begin(9600);
  lcd.setBacklightPin(3, POSITIVE);
  lcd.setBacklight(HIGH);
  lcd.begin(16, 2);
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Awaiting");
  lcd.setCursor(0, 2);
  lcd.print("Password");
  lcd.setCursor(0, 0);
}

void loop() {
  unsigned long currentMillis = millis();

  if(waiting == false && input == "inici"){
    if (!done && (currentMillis - previousMillis >= interval)) {
      previousMillis = currentMillis;
      temp--;
    }

    if (temp > 0) {
      char customKey = customKeypad.getKey();

      if (customKey && isdigit(customKey)) {
        password = password + customKey;
      } else if (customKey == 'A') {
        password = DarrerCaracter(password);
      } else if (customKey == 'B') {
        lcd.clear();
        password = "";
      } else if (customKey == '#') {
        done = true;
        Serial.println(password);
        waiting = true;
      }
      if (!done) {
        Actualitzar(Encriptar(password), temp);
      }
    } else {
      lcd.clear();
      lcd.print("Time is UP");
    }
  }
  else if(input != "inici" && waiting == true){
    lcd.clear();
    lcd.print(input);
  } 
}

String DarrerCaracter(String input) {
  String output = "";
  lcd.clear();

  if (input.length() == 0) {
    output = "";
  } else {
    for (int i = 0; i < input.length() - 1; i++) {
      output = output + input.charAt(i);
    }
  }

  return output;
}

String Encriptar(String input) {
  String output = "";
  for (int i = 0; i < input.length(); i++) {
    output = output + "*";
  }
  return output;
}

void Actualitzar(String input, int temp) {
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print(input);
  lcd.setCursor(0, 1);
  lcd.print(temp);
}

void serialEvent() {
  input = "";
  while (Serial.available()) {
    inChar = (char)Serial.read();
    if (inChar == '\n') {
      stringComplete = true;
      input = inputString;
      lcd.clear();
      lcd.print("Procesing...");
      delay(2000);
    }
    else{
      inputString += inChar;
    }
  }
}