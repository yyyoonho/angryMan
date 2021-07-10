using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeyManager : MonoBehaviour
{
    static KeyManager instance;
    public static KeyManager Instance { get { Init(); return instance; } }

    public Action KeyAction = null;

    static void Init()
    {
        if (instance == null)
        {
            GameObject obj = GameObject.Find("@KeyManager");
            if (obj == null)
            {
                obj = new GameObject { name = "@KeyManager" };
                obj.AddComponent<KeyManager>();
            }

            DontDestroyOnLoad(obj);
            instance = obj.GetComponent<KeyManager>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey == false)
            return;

        if (KeyAction != null)
            KeyAction.Invoke();
    }
}
