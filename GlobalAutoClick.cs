using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAutoClick : MonoBehaviour
{
    public GameObject FakeButton;
    public GameObject FakeText;
    public GameObject RealButton;
    public GameObject RealText;
    public int CurrentBL;
    public static int AutoClickValue = 1; 
    public static bool TurnOffButton = false;
    public GameObject AutoClickStatsPC;
    public GameObject AutoClickStatsHBPS;
    public static int NumberOfAutoClickers;
    public static int ClickPerSecond;

    void Start()
    {
        
    }

    void Update()
    {
        CurrentBL = GlobalExBL.BLCount;
        AutoClickStatsPC.GetComponent<Text>().text = "Pace Makers: " + NumberOfAutoClickers;
        AutoClickStatsHBPS.GetComponent<Text>().text = "Heart Beats Per Second: " + ClickPerSecond;
        FakeText.GetComponent<Text>().text = "Pace Maker- " + AutoClickValue + "ml";
        RealText.GetComponent<Text>().text = "Pace Maker- " + AutoClickValue + "ml";

        if (CurrentBL >= AutoClickValue) {
            FakeButton.SetActive(false);
            RealButton.SetActive(true);
        }

        if (TurnOffButton == true) {
            RealButton.SetActive(false);
            FakeButton.SetActive(true);
            TurnOffButton = false;
        }
    }
}
