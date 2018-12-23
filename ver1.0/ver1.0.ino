#include <Servo.h>

// tanımlamalar
 int buton_pin = 22;
 
 const int servo_1 =8;
 int servo_1val ;
 Servo servo1 ;

 const int servo_2 =9;
 int servo_2val ;
 Servo servo2 ;
 
// degerler
int x_deger = 0;
int y_deger = 0; 
int buton_deger = 0;

void setup() {
  Serial.begin(9600);
   servo1.attach(servo_1);
   servo2.attach(servo_2);
  pinMode(buton_pin,INPUT_PULLUP);
  
}

void loop() {
kontrol();
servo1_kontrol(y_deger);
servo2_kontrol(x_deger);

}
void kontrol()
{
   x_deger = analogRead(A14);
 y_deger = analogRead(A15);
 buton_deger = digitalRead(buton_pin);
// Serial.println("X Değeri:");
// Serial.println(x_deger);
// Serial.println("Y Değeri:");
// Serial.println(y_deger);
// Serial.println("Buton Durumu");
// Serial.println(buton_deger);
//
// delay(1000);
 
  }
void servo1_kontrol(int data)
{
 
  servo_1val=map(data,0,1023,0,180);
  servo1.write(servo_1val);
  delay(10);
  }
  void servo2_kontrol(int data)
{
  servo_2val=map(data,0,1023,0,180);
  servo2.write(servo_2val);
    delay(10);
  
  }
  
