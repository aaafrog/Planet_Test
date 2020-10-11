using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.SceneManagement;

public class Stage1Manager : MonoBehaviour
{
    //居住区
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stage0_DoorClick()
    {
        Debug.Log("Stage0_DoorClick");
        SceneManager.LoadScene("SceneStage0");
    }
    public void Stage2_DoorClick()
    {
        Debug.Log("Stage2_DoorClick");
        SceneManager.LoadScene("SceneStage2");
    }

    public void RefrigeratorClick()
    {
        Debug.Log("RefrigeratorClick");
    }

    public void ParkingMachineClick()
    {
        Debug.Log("ParkingMachineClick");
    }

}
