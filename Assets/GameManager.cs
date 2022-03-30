using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text meowsText;
    public static int meows;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        meowsText.text = meows + " Meows";
        
    }
}
