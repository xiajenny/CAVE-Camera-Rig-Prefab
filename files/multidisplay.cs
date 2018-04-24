using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class multidisplay : MonoBehaviour {

    Camera[] multiDisplay = new Camera[4];
    void Start()
    {
        //find cameras and assign to multiDisplay
        multiDisplay[0] = GameObject.Find("FrontRightCam").GetComponent<Camera>();
        multiDisplay[1] = GameObject.Find("LeftCam").GetComponent<Camera>();
        multiDisplay[2] = GameObject.Find("FrontLeftCam").GetComponent<Camera>();
        multiDisplay[3] = GameObject.Find("RightCam").GetComponent<Camera>();

        //set and enable the displays
        for (int i = 0; i < Display.displays.Length; i++)
        {
            multiDisplay[i].targetDisplay = i; 
            Display.displays[i].Activate(); 
        }
    }
}
