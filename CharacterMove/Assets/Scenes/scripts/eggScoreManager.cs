using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI;
public class eggScoreManager : MonoBehaviour
{


    public static int score;
   
  
    public static void AddPoints(int eggToAdd)
    {
        score += eggToAdd;

    
        
        Debug.Log("Game Score: " + score);

    }
}
