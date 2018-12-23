#include <Servo.h>

// tanımlamalar
 int buton_pin = 22;
 
 const int servo_1 =8;
 int servo_1val ;
 Servo servo1 ;

 const int servo_2 =9;
 int servo_2val ;
 Servo servo2 ;

 const int servo_3 =10;
 int servo_3val ;
 Servo servo3 ;

  const int servo_4 =11;
 int servo_4val ;
 Servo servo4 ;
 
// degerler
int x_deger = 0;
int y_deger = 0; 
int x1_deger = 0;
int y1_deger = 0; 
void setup() {
  Serial.begin(9600);
   servo1.attach(servo_1);
   servo2.attach(servo_2);
   servo3.attach(servo_3);
   servo4.attach(servo_4);
  pinMode(buton_pin,INPUT_PULLUP);
  
}

void loop() {
kontrol();
servo1_kontrol(y_deger);
servo2_kontrol(x_deger);
servo3_kontrol(x1_deger);
servo4_kontrol(y1_deger);
}
void kontrol()
{
  x_deger = analogRead(A14);
    y_deger = analogRead(A15);
  x1_deger = analogRead(A13);
  y1_deger = analogRead(A12);
 
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
    void servo3_kontrol(int data)
{
if(data > 450)
     {
  servo_3val=map(data,0,1023,0,180);
  servo3.write(servo_3val);
    delay(10);
     }
  }
    void servo4_kontrol(int data)
{
  servo_4val=map(data,0,1023,0,180);
  servo4.write(servo_4val);
    delay(10);
  
  }
  
