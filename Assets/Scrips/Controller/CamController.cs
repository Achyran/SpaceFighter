using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    //This Needs be attached to the Pivot of the Player
    
    public Camera firstPersonCam;
    public Camera thirdPerosnCam;
    enum Cam {first =0, thrid =1 };
    Cam currencam;


    void Start()
    {
        firstPersonCam.enabled = true;
        thirdPerosnCam.enabled = false;
        currencam = Cam.first; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1)) switchCam();
    }

    void Rotate()
    {
        
    }

    void switchCam()
    {
        if (firstPersonCam.enabled)
        {
            firstPersonCam.enabled = false;
            thirdPerosnCam.enabled = true;
            currencam = Cam.thrid;
        }
        else
        {
            thirdPerosnCam.enabled = false;
            firstPersonCam.enabled = true;
            currencam = Cam.first;
        }
    }
}
