using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeHandler : MonoBehaviour
{
    #region Variables
    public Text bowlText;
    float bowlCost = 20;
    public Text strongerMeowText;
    float strongerMeowCost = 100;
    public Text neighbourText;
    float neighbourCost = 1000;
    public Text rodText;
    float rodCost = 5000;
    public Text netText;
    float netCost = 10000;
    float mps = 1f;
    #endregion
   
    public void PurchasedBowl()
    {
        if (GameManager.meows >= bowlCost)//if we have the money to purchase bowl
        {
            GameManager.meows -= bowlCost;//meows minus the cost
            GameManager.mpc += 1;
            bowlCost += 5;
            bowlText.text = "Bigger Bowl - " + bowlCost + "Meows";
            Debug.Log("Purchased Bowl");
        }

        else
        {
            Debug.Log("Cannot afford!");
        }
    }
    public void PurchasedStrongerMeow()
    {
        if (GameManager.meows >= strongerMeowCost)
        {
            GameManager.meows -= strongerMeowCost;
            GameManager.mpc += 5;
            strongerMeowCost += 10;
            strongerMeowText.text = "Stronger Meow - " + strongerMeowCost + "Meows";
            Debug.Log("Purchased Stronger Meow");
        }

        else
        {
            Debug.Log("Cannot afford!");
        }
    }

    public void PurchasedNeighbour()
    {
        if (GameManager.meows >= neighbourCost)
        {
            GameManager.meows -= neighbourCost;
            GameManager.mpc += 10;
            neighbourCost += 15;
            neighbourText.text = "Friendly Neighbour - " + neighbourCost + "Meows";
            Debug.Log("Purchased Neighbour");
        }

        else
        {
            Debug.Log("Cannot afford!");
        }
    }

    public void PurchasedFishingRod()
    {
        if (GameManager.meows >= rodCost)
        {
            GameManager.meows -= rodCost;
           GameManager.mpc += 15;
            rodCost += 20;
            rodText.text = "Fishing Rod - " + rodCost + "Meows";
            Debug.Log("Purchased Fishing Rod");
        }

        else
        {
            Debug.Log("Cannot afford!");
        }
    }

    public void PurchasedFishingNet()
    {
        if (GameManager.meows >= netCost)
        {
            GameManager.meows -= netCost;
            GameManager.mpc += 20;
            netCost += 25;
            netText.text = "Fishing Net - " + netCost + "Meows";
            Debug.Log("Purchased Fishing Net");
        }

        else
        {
            Debug.Log("Cannot afford!");
        }
    }

}
