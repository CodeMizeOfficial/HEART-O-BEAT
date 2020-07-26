using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClick : MonoBehaviour
{
    public bool MakingHeartBeats = false;
    public static int HeartBeatIncrease = 1;
    public int InternalHBIncrease;
    public GameObject Heart1;

    void Update()
    {
        InternalHBIncrease = HeartBeatIncrease;
        
        if (MakingHeartBeats == false) {
            MakingHeartBeats = true;
            StartCoroutine(MakeTheHeartBeat());
        }
    }

    IEnumerator MakeTheHeartBeat () {
        GlobalHeartBeat.HeartBeatCount += InternalHBIncrease;
        yield return new WaitForSeconds(1);
        Heart1.GetComponent<Animation>().Play("HeartPumpingAnimation");
        MakingHeartBeats = false;
    }
}
