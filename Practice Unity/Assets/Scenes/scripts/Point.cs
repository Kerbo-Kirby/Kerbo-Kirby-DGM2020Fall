using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public static int score; 
 
    
 
    public static void AddPoints(int pointsToAdd) 
    { 
        score += pointsToAdd; 
        Debug.Log("Game Score: " + score); 
 
    } 
}
