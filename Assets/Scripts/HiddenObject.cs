using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        //Check object off of list
        GameManager.Instance.objectList.Remove(this);
        //Destroy Object or Make inactive
        this.gameObject.SetActive(false);
    }
}
