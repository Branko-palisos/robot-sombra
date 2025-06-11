using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLogSceneController : MonoBehaviour
{
    [SerializeField]
    int lastCompletedLevel = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
  internal void ChangeLastLevelCompleted(int _amount)
    {
        lastCompletedLevel += _amount;
    }

    // Update is called once per frame;
    internal int GetLastCompletedLevel()
    {
        return lastCompletedLevel;  
    }
    
}
