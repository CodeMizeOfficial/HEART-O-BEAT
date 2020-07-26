using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartClick : MonoBehaviour
{
    public GameObject Heart;
    

    public void ClickTheButton() {
        GlobalHeartBeat.HeartBeatCount += 1;
        Heart.GetComponent<Animation>().Play("HeartPumpingAnimation");
    }
}
