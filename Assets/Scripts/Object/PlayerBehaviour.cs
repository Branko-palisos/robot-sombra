using System.Collections;
//using System.Collections.Generic;
//using System.Data.Common;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;
//using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerBehaviour : MonoBehaviour
{
    internal float fruitCount;
    public TextMeshProUGUI fruitCountTMP;
    public TextMeshProUGUI TAP;
    public TextMeshProUGUI DETAP;
    public MainMenuSceneController mainMenuSceneController; 
    public GameObject continueButton;
    public GameObject BackToMenu;
    [SerializeField]
    internal float speed = 5.0f;
    public Vector3 growFactor = new Vector3(0.1f, 0.1f, 0.1f);
    private Vector3 growLimit = new Vector3(2, 2, 2);
    private Animator animator;
    public bool bill = false;
    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
      //  TAP.gameObject.SetActive(false);
      //  DETAP.gameObject.SetActive(false);
       // continueButton.gameObject.SetActive(false);
     //   BackToMenu.gameObject.SetActive(false);
      //  Debug.Log("Ever since I was a kid");
    }
 
    // Update is called once per frame
     void Update()
    {
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                Debug.Log("Level 1");
                Level1Movement();
            fruitCount = 3;
            Debug.Log("Win");
         //   FindObjectOfType<LevelLogSceneController>().ChangeLastLevelCompleted(1);
            //SceneManager.LoadScene("Level 2");     
            TAP.gameObject.SetActive(true);
            animator.SetTrigger(EnumManager.AnimatiorParameters.DanceTrigger.ToString());
            SceneManager.LoadScene(EnumManager.Scenes.Level2.ToString());
            }

        // si el nombre de la escena actual es equal a nivel 1
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            fruitCount = 195;
            if (fruitCount > 199)
            {
                //  Debug.Log("Level 2");
           
                Debug.Log("Win");
                //SceneManager.LoadScene("Level 2");     
                //  animator.SetTrigger(EnumManager.AnimatiorParameters.DanceTrigger.ToString());
            }

            Level2Movement();
        }
        Vector3 direction = new Vector3 (0,1,0);    
        Vector3 velocity  = direction * speed;

        
    }
 
    void Level1Movement()
    {
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(1 * speed * Time.deltaTime, 0, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, 1 * speed * Time.deltaTime, 0);
        }
    }
    void Level2Movement()
    {
        Debug.Log("Lewvel 2 movemenr");
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(1 * speed * Time.deltaTime, 0, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("w"))
        {
           
            bill = true;
           
        }
        if (bill == true)
        {
            transform.position += new Vector3(0, 1 * speed * Time.deltaTime, 0);
        }
    }
   internal void GetFruit()
    {
        StartCoroutine(GetFruitCR());
    }
    IEnumerator GetFruitCR()
    {
      
        fruitCount += 1;
        if (fruitCount > 3)
        {
            fruitCount = 3;
            Debug.Log("Win");
     //       FindObjectOfType<LevelLogSceneController>().ChangeLastLevelCompleted(1);
            //SceneManager.LoadScene("Level 2");     
            TAP.gameObject.SetActive(true);
          animator.SetTrigger(EnumManager.AnimatiorParameters.DanceTrigger.ToString());
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(EnumManager.Scenes.Level2.ToString());
        }
        Grow();
      

        UpdateFruitCountTMP();
        Debug.Log("fruitCount = " + fruitCount);

    } 
    internal void UpdateFruitCountTMP()
    {
        fruitCountTMP.text = fruitCount.ToString();
      
    }
   internal float GetSpeed()
    {
        return speed;
    }
   internal void SetSpeed(float _amount)
    {
        speed = _amount;
    }
    internal void ChangeSpeed( float _change)
    {
        speed += _change;
    }
    
    public void Death()
    {
        StartCoroutine(DeathCorutine());
    }
    IEnumerator DeathCorutine()
    {
        Destroy(gameObject);
        
        GetComponent<SpriteRenderer>().enabled = false;
        animator.SetTrigger("Fade");
        DETAP.gameObject.SetActive(true);
        continueButton.gameObject.SetActive(true);
        BackToMenu.gameObject.SetActive(true);  
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SampleScene");
    }
    public void Grow()
    {
        transform.localScale += growFactor;
        if (transform.localScale.x > 2)
        {
            transform.localScale = growLimit;
        }
    }
    internal void ObtainFruit()
    {
        Debug.Log("speed up");
    }
   internal float GetFruitCount()
    {
       return fruitCount;   
 
    }
 

}