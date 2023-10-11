using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Noise : MonoBehaviour
{
    public Vector3 prevMouse;
    public Vector3 currMouse;
    public float deltaX;
    public float deltaY;
    public float displacement;

    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        prevMouse = Input.mousePosition;
        slider = gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 10 == 0)
        {
            prevMouse = currMouse;
            currMouse = Input.mousePosition;
            deltaX = currMouse.x - prevMouse.x;
            deltaY = currMouse.y - prevMouse.y;
            displacement = Mathf.Sqrt(Mathf.Pow(deltaX, 2) + Mathf.Pow(deltaY, 2));
        
            if (slider.value < displacement && displacement > 5.0f)
                slider.value += 4.0f * Time.deltaTime;
            else if (slider.value < displacement)
                slider.value += 2.0f * Time.deltaTime;
            else
                slider.value -= 1.0f * Time.deltaTime;
        }
    }
}
