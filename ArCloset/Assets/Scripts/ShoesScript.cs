using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoesScript : MonoBehaviour
{
    void Start()
    {
        GameObject Clothes = GameObject.Find("Shoes");
        Clothes.SetActive(false);

        print("hidden");
        //SaveComponents();
    }

    //private void SaveComponents()
    //{
    //    button = gameObject.GetComponent<Button>();
    //    theColor = gameObject.GetComponent<Button>().colors;
    //}


    //public void OnMouseDown()
    //{
    //    Debug.Log("Button was pressed!");
    //    changeColorButton();
    //    //GameObject Clothes = GameObject.Find("Clothes");
    //    //Clothes.SetActive(true);
    //}

    //private void changeColorButton()
    //{
    //    Debug.Log("ChangedColor");

    //}
}


