using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExchangeBL : MonoBehaviour
{
    public GameObject SellButton;
    public GameObject StatusBox;

    public void ClickTheButton() {
        if (GlobalHeartBeat.HeartBeatCount >= 10)
        {
            GlobalHeartBeat.HeartBeatCount -= 10;
            GlobalExBL.BLCount += 1;
        }
        else {
            StatusBox.GetComponent<Text>().text = "Not Enough Heart Beats to Exchange!";
            StatusBox.GetComponent<Animation>().Play("StatusAnimation");
        }
    }
}
