using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlUpgrade : MonoBehaviour
{

    public Text costText;
    int cost = 20;

   public void Purchased()
    {
        if (GameManager.meows >= cost) //if we have the money
        {
            GameManager.meows -= cost; //pokes minus the cost
            CookieClickerHandler.mpc += 1;
            cost += 10;
            costText.text = "Bigger Bowl - " + cost + " Meows";
        }
        else
        {
            Debug.Log("Cannot afford!");
        }
    }
}
