using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnPressButtonTshirt : MonoBehaviour
{
    private Button button;
    private ColorBlock theColor;

    void Start()
    {
        //print("hallo");
        SaveComponents();
    }

    private void SaveComponents()
    {
        button = gameObject.GetComponent<Button>();
        theColor = gameObject.GetComponent<Button>().colors;
    }


    public void OnMouseDown()
    {
        Debug.Log("Button was pressed!");
        changeColorButton();


    }

    private void changeColorButton()
    {
        Debug.Log("ChangedColor");
        theColor.highlightedColor = Color.blue;
        //theColor.pressedColor = Color.green;
    }
}
