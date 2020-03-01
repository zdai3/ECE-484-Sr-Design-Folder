/* This is the pseudo-codes for team_5's portable material inspector (PMI) */

#include <stdio.h>
#include <iostream>
#include "TensorFlowML.h"

int USB_Status = 0;
int UI_Status = 0;

void Usb_connection_Check(){
    int i = 1;
    while (i)
    {
      if(/*USB signal detected*/){
          USB_Status = 1; // connected
          i = 0;          // exit loop
        }
        else{
          USB_Status = 0; // not connected
        }
    }
}

void User_Interface_Check(){
    while (UI_Status != 1){
        if (/*UI Launched*/)
            UI_Status = 1;  // UI launched and exit loop
    }
};

void Power_Off(){
    POWER_ON = 0; /*As well as other power off commands*/
}

// USB Connectivity:

void USB_Connectivity(){
    Usb_connection_Check(); /* loop will be aborted when usb connection check complete */

    if(PMI_DRIVER_INSTALLED){ /* if the driver for the portable material inspector (PMI) is installed */
        PMI_Driver().run(); // initialize run PMI driver
        PMI_Driver().Power_Supply(); /* make sure enough power is delivered to PMI*/

        while (!PMI_Driver().disconnect()){ // while PMI is connected    
            PMI_Driver().Data_Stream(); /* transfer camera live view and pictures captured through USB connection */
            PMI_Driver().Btn_Press_Command(); /* transfer the button press command from the PC to the PMI */
        }
    }
    else{
        PMI_Driver().install(); // install driver
    }
}

// Image Capture Control:

void Image_Capture_Control(){
        if(CAPTURE_BTN){ // If capture button press detected
            PMI_Driver().Capture(); /*Capture the picture of the inspection area */
            Preview_Display = PMI_Driver().Data_Stream().BitmapDisplay().LastestCapture(); /*Displaying the latest picture captured */
        }
        else{
            Preview_Display = PMI_Driver().Data_Stream().BitmapDisplay().live(); /*Displaying live camera view of the inspection area */
        }
}


int main(){ 
    // initialization and status checking when powered on
    bool defect_detected = false;
    int defect_type = 0;
    int captured = 0;
    TensorFlowML tenserflowML = new TenserFlowML();
    USB_Connectivity();
    User_Interface_Check(); 

    while(POWER_ON){
        Image_Capture_Control();
        if(ANALYZE_BTN){
            if(captured){
                tenserflowML(BitmapDisplay().bitmap);         //feed the captured picture into the ML algorithms
                defect_detected = tenserflowML.Defect_Status; // check defects
                if (defect_detected)
                {
                    defect_type = tenserflowML.Defect_Type; // Assign and display defect types to the screen
                    tenserflowML.Education_Material_Display(defect_type);
                    Preview_Display = PMI_Driver().Data_Stream().BitmapDisplay().live(); /*Displaying live camera view of the inspection area */
                }
                else{
                    cout<<"No Error Detected"<<endl;
                    Preview_Display = PMI_Driver().Data_Stream().BitmapDisplay().live(); /*Displaying live camera view of the inspection area */
                }
                captured = 0;
            }
        }
        if(POWER_OFF){Power_Off();}
    }
}
