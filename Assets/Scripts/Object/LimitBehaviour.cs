using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collideWith "+collision.gameObject.name);
        //Destroy(collision.gameObject);  
        collision.gameObject.GetComponent<PlayerBehaviour>().Death();
        Debug.Log("Lose");
    }
}
