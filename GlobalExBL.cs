using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalExBL : MonoBehaviour
{
   public static int BLCount;
   public GameObject BLDisplay;
   public int InternalBL;

    // Update is called once per frame
    void Update()
    {
        InternalBL = BLCount;
        BLDisplay.GetComponent<Text>().text = "BLOOD LEVEL: " + InternalBL + "ml";
    }
}
