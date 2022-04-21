using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieClickerHandler : MonoBehaviour
{
    public static float mpc = 1; //meows per click
    public void Click()
    {
        GameManager.meows += mpc;
        Debug.Log(GameManager.meows);
        
    }


    
}
