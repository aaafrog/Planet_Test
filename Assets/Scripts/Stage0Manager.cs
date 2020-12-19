using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.SceneManagement;

public class Stage0Manager : MonoBehaviour
{
    public GameObject Washing_Machine_Button;


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

    // 発酵促進器クリック時
    public void WashingMachineClick()
    {
        Washing_Machine_Button.SetActive(true);

        // アイテムを選択
        Debug.Log("アイテムを選択");

    }

    // 促進器を起動させる
    public void StartClick()
    {
        int sio = FlagManager.Instance.ItemFlags[0];
        int daizu = FlagManager.Instance.ItemFlags[1];
        int kouji = FlagManager.Instance.ItemFlags[2];
        int natto = FlagManager.Instance.ItemFlags[3];

        
        if (kouji == 2 || sio == 2 || daizu == 2)// アイテムが麹菌・大豆・塩の場合
        {
            ItemManager.instance.OnGetItem();
            Debug.Log("みそ");
        }
        else if (natto == 2 || sio == 2 || daizu == 2)// アイテムが納豆菌・大豆・塩の場合
        {
            Debug.Log("納豆");
        }
        else // アイテムが３つセットされていない
        {
            Debug.Log("セットされてない");
        }

        Washing_Machine_Button.SetActive(false);
    }

public void VendingMachineClick()
    {
        Debug.Log("VendingMachineClick");
    }

}
