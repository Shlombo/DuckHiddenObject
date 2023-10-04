using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<HiddenObject> objectList;

    public static GameManager Instance { get; private set; }

    public TimerObject timer;

    public static int currentLevel = 1;

    public int test;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        test = currentLevel;
        if(objectList.Count <= 0) {
            currentLevel += 1;
            Debug.Log("Yippee");
            if(currentLevel == 2){
                SceneManager.LoadScene("Level 2 Prefix");
            } else if(currentLevel == 3){
                SceneManager.LoadScene("Level 3 Prefix");
            } else if(currentLevel == 4) {
                SceneManager.LoadScene("Level 4 Prefix");
            } else if(currentLevel == 5) {
                SceneManager.LoadScene("Finale");
            }
        }
        if(timer.currentTime <= 0) {
            currentLevel = 1;
            SceneManager.LoadScene("Game Over");
        }
    }

    void Awake() 
    {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }
}
