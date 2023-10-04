using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<HiddenObject> objectList;

    public static GameManager Instance { get; private set; }

    public TimerObject timer;

    bool done = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(objectList.Count <= 0 && !done) {
            Debug.Log("Yippee");
            done = true;
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
