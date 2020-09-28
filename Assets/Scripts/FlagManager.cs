using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagManager : MonoBehaviour
{
    private static FlagManager instance = null;
    public static FlagManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<FlagManager>();

                if (instance == null)
                {
                    instance = new GameObject("FlagManager").AddComponent<FlagManager>();
                }
            }
            return instance;
        }
    }

    void Awake()
    {
        if (Instance == this)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool[] flags = new bool[128];

    [ContextMenu("ResetFlags")]
    public void ResetFlags()
    {
        flags = new bool[flags.Length];
    }





    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}
