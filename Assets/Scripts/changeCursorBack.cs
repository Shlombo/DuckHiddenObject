using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCursorBack : MonoBehaviour
{
    // Start is called before the first frame update
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    void Start()
    {
        Cursor.SetCursor(null, hotSpot, cursorMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
