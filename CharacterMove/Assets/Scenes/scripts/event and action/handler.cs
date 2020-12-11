
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameActionAssetHandler : ScriptableObject
{
    
    
    //what i learned from anthony
    
    
    
    public GameAction gameActionObject;
    public UnityEvent handleEvent;
    
    private void OnEnable()
    {
        gameActionObject.action += Handler;
    }

    private void Handler()
    {
        handleEvent.Invoke();
    }
}

