using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2Manager : MonoBehaviour
{
    public GameObject Cage;
    public GameObject Sardine;
    //[SerializeField] GameObject Cage;
    //[SerializeField] GameObject Sardine;

    //外宇宙
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

    public void mvStage1()
    {
        SceneManager.LoadScene("SceneStage1");
    }
    public void mvStage3()
    {
        SceneManager.LoadScene("SceneStage3");
    }

    public void OnClickCage()
    {
        //アラ汁フラグテスト
        //アラ汁のアイテムを選択したらに修正
        //FlagManager.Instance.ItemFlags[6] = 1;

        if (FlagManager.Instance.ItemFlags[6] == 2)
        {
            // アラ汁を持っている
            Debug.Log("アラ汁を持っている");
            Cage.SetActive(false);
        }
        else
        {
            // アラ汁を持っていない
            Debug.Log("アラ汁を持っていない");
        }
    }
/*    public void OnClickSardine()
    {
        ItemManager.instance.OnGetItem();
        Debug.Log("魚の骨を手に入れた！");
        Sardine.SetActive(false);

        //  イワシを食べる
        Debug.Log("イワシを食べる");
        FlagManager.Instance.ItemFlags[7] = 1;
    }
    public void OnClickSardineBone()
    {
        //  魚の骨
        Debug.Log("イワシを食べる");
        FlagManager.Instance.ItemFlags[7] = 1;
    }*/

}
