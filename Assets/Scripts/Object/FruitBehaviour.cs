using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    PlayerBehaviour playerBehaviour;        
    public GameObject sharky;
    private int minX = -8;
    private int maxX = 8;
    private float minY = -3.5f;
    private float maxY = 3.5f;
    [SerializeField]

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
        Debug.Log("CollidedWith =  " + collision.gameObject.name);
        sharky.GetComponent<PlayerBehaviour>().GetFruit();
        gameObject.SetActive(false);

        this.GetComponent<Transform>().position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
        gameObject.SetActive(true);
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            Debug.Log("speed up");
            playerBehaviour.speed += 0.8f;
          
          
        }
            if (playerBehaviour.fruitCount == 3.0f )
        {
           
            Debug.Log("Win");
        }
            if(playerBehaviour.fruitCount == 199.0f)
        {
            Debug.Log("Win again");
        }
    }
}
