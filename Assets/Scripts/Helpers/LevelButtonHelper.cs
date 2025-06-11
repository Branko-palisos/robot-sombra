using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class LevelButtonHelper : MonoBehaviour
{
    [SerializeField]
    int myLevel;
    // Start is called before the first frame update
    void Start()
    {
        Disable();   
    }

    // Update is called once per frame
    private void Disable()
    {
        if (myLevel <= FindObjectOfType<LevelLogSceneController>().GetLastCompletedLevel()+1)
        {
            Debug.Log("Active");
           
        }
        else
        {
            Debug.Log("Disabled");
            Destroy(gameObject);
        }
    }
}

