using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.SceneManagement;

public class Stage0Manager : MonoBehaviour
{
    public GameObject Miso_Button;
    public GameObject Natto_Button;
    public GameObject NoSet_Button;

    private int NoSetFlag;

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
        int sio = FlagManager.Instance.ItemFlags[0];
        int daizu = FlagManager.Instance.ItemFlags[1];
        int kouji = FlagManager.Instance.ItemFlags[2];
        int natto = FlagManager.Instance.ItemFlags[3];


        if ( sio == 2 && daizu == 2 && kouji == 2 )// アイテムが麹菌・大豆・塩の場合
        {
            Miso_Button.SetActive(true);
            Debug.Log("みそ");
        }
        else if ( sio == 2 && daizu == 2 && natto == 2)// アイテムが納豆菌・大豆・塩の場合
        {
            Natto_Button.SetActive(true);            
            Debug.Log("納豆");
        }
        else // アイテムが３つセットされていない
        {
            NoSetFlag = 1;
            NoSet_Button.SetActive(true);
            Debug.Log("セットされてない");
        }

        // アイテムを選択
        Debug.Log("アイテムを選択");

    }


    // ボタンクリック時
    public void MachineStart()
    {
        if (NoSetFlag != 1)
        {
            ItemManager.instance.OnGetItem();
        }

        Miso_Button.SetActive(false);
        Natto_Button.SetActive(false);
        NoSet_Button.SetActive(false);

    }


    public void VendingMachineClick()
    {
        Debug.Log("VendingMachineClick");
    }

}
