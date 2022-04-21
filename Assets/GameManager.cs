using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text meowsText;
    public static float meows;
    public static float mpc = 1; //meows per click

    public void Click()
    {
        meows += mpc;
        Debug.Log(meows);

    }
    
    void Update()
    {
        meowsText.text = meows + " Meows";
        
    }

}
