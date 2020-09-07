using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    
    
    
    
    
    public static void Add(int Add)
    {
        Score += Add;
        Debug.Log("Game Score: " + Score);
    }
}
    

