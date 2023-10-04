using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickControl : MonoBehaviour
{

    public static string nameOfObj;

    public TMP_Text objNameText;



    // Start is called before the first frame update
    void Start()
    {
        nameOfObj = gameObject.name;
        objNameText.text = nameOfObj;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        nameOfObj = gameObject.name;
        Debug.Log(nameOfObj);
        Destroy(gameObject);
        Destroy(objNameText);
    }

}
