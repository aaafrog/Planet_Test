using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.SceneManagement;

public class Stage1Manager : MonoBehaviour
{

    public GameObject Parking_Machine_Button;

    //居住区
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
        Parking_Machine_Button.SetActive(true);

        // アイテムを選択
        Debug.Log("アイテムを選択");
    }


    // フードプリンターを起動させる
    public void StartClick()
    {
        int miso = FlagManager.Instance.ItemFlags[4];
        int hone = FlagManager.Instance.ItemFlags[7];


        if (miso == 2 || hone == 1)// アイテムが麹菌・大豆・塩の場合
        {
            ItemManager.instance.OnGetItem();
            Debug.Log("味噌汁");
        }
        else if (miso == 2 || hone == 2)// アイテムが納豆菌・大豆・塩の場合
        {
            Debug.Log("あら汁");
        }
        else // アイテムが３つセットされていない
        {
            Debug.Log("セットされてない");
        }

        Washing_Machine_Button.SetActive(false);
    }


    public void PotClick()
    {
        Debug.Log("ParkingMachineClick");
    }

}
