using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MSN : MonoBehaviour
{
    // Start is called before the first frame update
    public int pot;
    void Start()
    {
        SerialManagerScript.WhenReceiveDataCall += ReceiveData;
    }

    private void ReceiveData(string incomingString)
    {
        int.TryParse(incomingString,out pot);
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SerialManagerScript.SendInfo("a");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            SerialManagerScript.SendInfo("b");
        }

    }
}
