/******************************************************************
 * PID Simple Example (Augmented with Processing.org Communication)
 * Version 0.3
 * by Brett Beauregard
 * License: Creative-Commons Attribution Share-Alike
 * April 2011
 ******************************************************************/

#include <PID_v1.h>

//Define Variables we'll be connecting to
double Setpoint, Input, Output;
int inputPin=0, outputPin=6;

//Specify the links and initial tuning parameters
PID myPID(&Input, &Output, &Setpoint,0.1,0.28,0, DIRECT);


unsigned long serialTime; //this will help us know when to talk with processing

void setup()
{
  //initialize the serial link with processing
  Serial.begin(9600);
  
  //initialize the variables we're linked to
  Input = analogRead(inputPin);
  Setpoint = 950;

  //turn the PID on
  myPID.SetMode(AUTOMATIC);
}

void loop()
{
  //pid-related code
  Input = analogRead(inputPin);
  myPID.Compute();
  analogWrite(outputPin,Output);
  

  
  //send-receive with processing if it's time
  if(millis()>serialTime)
  {
    //SerialReceive();
    SerialACK();
    SerialSend();
    serialTime+=500;
  }
  
  
}




/********************************************
 * Serial Communication functions / helpers
 ********************************************/


union {                // This Data structure lets
  byte asBytes[24];    // us take the byte array
  float asFloat[6];    // sent from processing and
}                      // easily convert it to a
foo;                   // float array

String getValue(String data, char separator, int index)
{
 int found = 0;
  int strIndex[] = {
0, -1  };
  int maxIndex = data.length()-1;
  for(int i=0; i<=maxIndex && found<=index; i++){
  if(data.charAt(i)==separator || i==maxIndex){
  found++;
  strIndex[0] = strIndex[1]+1;
  strIndex[1] = (i == maxIndex) ? i+1 : i;
  }
 }
  return found>index ? data.substring(strIndex[0], strIndex[1]) : "";
}

void SerialACK(){
  String str;
  int index=0;
  if (Serial.available() && index == 0) {
      double p, i, d;
      String mode, controller;
      str = Serial.readStringUntil('\n');
      if (getValue(str, ' ', 0).toFloat() != 0){
        Setpoint = getValue(str, ' ', 0).toFloat();
      }
      p = getValue(str, ' ', 1).toFloat();
      i = getValue(str, ' ', 2).toFloat();
      d = getValue(str, ' ', 3).toFloat();
      mode = getValue(str, ' ', 4);
      controller = getValue(str, ' ', 5);

/*
      Serial.print("Setpoint: ");
      Serial.print(Setpoint);
      Serial.print(" p: ");
      Serial.print(p);
      Serial.print(" i: ");
      Serial.print(i);
      Serial.print(" d: ");
      Serial.println(d);
*/
      if(p!=0 || i!=0 || d!=0){
        myPID.SetTunings(p, i, d);
      }
      if (mode == "Automatic"){
        myPID.SetMode(AUTOMATIC);
      }else if (mode == "Manual"){
        myPID.SetMode(MANUAL);
      }

      if(controller == "Direct"){
        myPID.SetControllerDirection(DIRECT);
      }else if(controller == "Reverse"){
        myPID.SetControllerDirection(REVERSE);  
      }
      
      index++;
      Serial.flush();
      delay(1000);
  }
  
}



// getting float values from processing into the arduino
// was no small task.  the way this program does it is
// as follows:
//  * a float takes up 4 bytes.  in processing, convert
//    the array of floats we want to send, into an array
//    of bytes.
//  * send the bytes to the arduino
//  * use a data structure known as a union to convert
//    the array of bytes back into an array of floats

//  the bytes coming from the arduino follow the following
//  format:
//  0: 0=Manual, 1=Auto, else = ? error ?
//  1: 0=Direct, 1=Reverse, else = ? error ?
//  2-5: float setpoint
//  6-9: float input
//  10-13: float output  
//  14-17: float P_Param
//  18-21: float I_Param
//  22-245: float D_Param
/*
void SerialReceive()
{

  // read the bytes sent from Processing
  int index=0;
  byte Auto_Man = -1;
  byte Direct_Reverse = -1;
  while(Serial.available()&&index<26)
  {
    if(index==0) Auto_Man = Serial.read();
    else if(index==1) Direct_Reverse = Serial.read();
    else foo.asBytes[index-2] = Serial.read();
    index++;
  } 
  
  // if the information we got was in the correct format, 
  // read it into the system
  if(index==26  && (Auto_Man==0 || Auto_Man==1)&& (Direct_Reverse==0 || Direct_Reverse==1))
  {
    Setpoint=double(foo.asFloat[0]);
    //Input=double(foo.asFloat[1]);       // * the user has the ability to send the 
                                          //   value of "Input"  in most cases (as 
                                          //   in this one) this is not needed.
    if(Auto_Man==0)                       // * only change the output if we are in 
    {                                     //   manual mode.  otherwise we'll get an
      Output=double(foo.asFloat[2]);      //   output blip, then the controller will 
    }                                     //   overwrite.
    
    double p, i, d;                       // * read in and set the controller tunings
    p = double(foo.asFloat[3]);           //
    i = double(foo.asFloat[4]);           //
    d = double(foo.asFloat[5]);           //
    myPID.SetTunings(p, i, d);            //
    
    if(Auto_Man==0) myPID.SetMode(MANUAL);// * set the controller mode
    else myPID.SetMode(AUTOMATIC);             //
    
    if(Direct_Reverse==0) myPID.SetControllerDirection(DIRECT);// * set the controller Direction
    else myPID.SetControllerDirection(REVERSE);          //
  }
  Serial.flush();                         // * clear any random data from the serial buffer
}
*/
// unlike our tiny microprocessor, the processing ap
// has no problem converting strings into floats, so
// we can just send strings.  much easier than getting
// floats from processing to here no?
void SerialSend()
{
  Serial.print("PID ");
  Serial.print(Setpoint);   
  Serial.print(" ");
  Serial.print(Input);   
  Serial.print(" ");
  Serial.print(Output);   
  Serial.print(" ");
  Serial.print(myPID.GetKp());   
  Serial.print(" ");
  Serial.print(myPID.GetKi());   
  Serial.print(" ");
  Serial.print(myPID.GetKd());   
  Serial.print(" ");
  if(myPID.GetMode()==AUTOMATIC) Serial.print("Automatic");
  else Serial.print("Manual");  
  Serial.print(" ");
  if(myPID.GetDirection()==DIRECT) Serial.println("Direct");
  else Serial.println("Reverse");
}

