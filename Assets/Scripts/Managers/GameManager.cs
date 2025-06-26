// clean code completed!
//using System.Collections;
//using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    TextMeshProUGUI fruitCountTMP;
    TextMeshProUGUI TAP;
    TextMeshProUGUI DETAP;
    PlayerBehaviour playerBehaviour;
    int lastCompletedLevel = 0;
    internal static GameManager gameManager;
    //efuncisones
    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);  
    }
    void Start()
    {
      
        if( gameManager == null)
        {
            gameManager = this;     
        }
        // inmprimir nombre de la escena actual
        SceneManager.GetActiveScene();
        //Debug.Log(SceneManager.GetActiveScene().name);
    }
    private void Update()
    {
        TAP.gameObject.SetActive(true);
        
    }
    void FuncionDelEmisor()

    {

        // si hay alguien escuchando

 

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
