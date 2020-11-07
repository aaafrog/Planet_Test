using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.SceneManagement;

public class Stage0Manager : MonoBehaviour
{
    //研究室
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("ControllerItem", LoadSceneMode.Additive);
        SceneManager.LoadScene("ControllerMenu", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Stage1_DoorClick()
    {
        Debug.Log("Stage1_DoorClick");
        SceneManager.LoadScene("SceneStage1");
    }

    public void WashingMachineClick()
    {
        Debug.Log("WashingMachineClick");
    }

    public void VendingMachineClick()
    {
        Debug.Log("VendingMachineClick");
    }

}
