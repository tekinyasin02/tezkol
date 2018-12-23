#include <Servo.h>

int servo_Dizi = 4;
int servo_Pin[] = {8, 9, 10, 11};
Servo servo[4];

void setup() {
  Serial.begin(9600);
  servoInit();

}

void loop() {
  
}

void serialEvent() {
  int servoNumara;
  int gelenDeger;
  
  servoNumara = Serial.readStringUntil(':').toInt();
  gelenDeger = Serial.readStringUntil('*').toInt();
  servo[servoNumara].write(gelenDeger);
  
}

void servoInit() {
  for(int i = 0; i < servo_Dizi; i++) {
    servo[i].attach(servo_Pin[i]);
    
  }
  
}

