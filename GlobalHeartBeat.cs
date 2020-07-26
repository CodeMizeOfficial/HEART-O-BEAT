using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHeartBeat : MonoBehaviour
{
   public static int HeartBeatCount;
   public GameObject HeartBeatDisplay;
   public int InternalHeartBeat;

    // Update is called once per frame
    void Update()
    {
        InternalHeartBeat = HeartBeatCount;
        HeartBeatDisplay.GetComponent<Text>().text = "HEART BEATS: " + InternalHeartBeat;
    }
}
