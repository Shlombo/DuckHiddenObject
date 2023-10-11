using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class changeCursor : MonoBehaviour
{
    
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    // Start is called before the first frame update
    // TextAsset bindata;
    void Start()
    {
        // bindata = Resources.Load("Assets/flashlight-on.png") as TextAsset;
        cursorTexture = new Texture2D(2, 2);
        // cursorTexture.LoadImage(bindata.bytes);

        cursorTexture = Resources.Load<Texture2D>("Textures/flashlight-off");
        GetComponent<Renderer>().material.mainTexture = cursorTexture;

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
    

    void OnMouseEnter()
    {
        
    }

    void OnMouseExit()
    {
        // Pass 'null' to the texture parameter to use the default system cursor.
// 
    }
}
