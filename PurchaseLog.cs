using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
   public GameObject AutoHB;

   public void StartAutoClicking () {
    AutoHB.SetActive(true);
    GlobalExBL.BLCount -= GlobalAutoClick.AutoClickValue;
    GlobalAutoClick.AutoClickValue *= 2;
    GlobalAutoClick.TurnOffButton = true;
    GlobalAutoClick.NumberOfAutoClickers += 1;
    GlobalAutoClick.ClickPerSecond += 1;
   }
}
