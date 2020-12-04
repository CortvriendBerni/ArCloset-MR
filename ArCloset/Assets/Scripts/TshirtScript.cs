using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TshirtScript : MonoBehaviour
{
 

    void Start()
    {
        GameObject Clothes = GameObject.Find("Tshirts");
        Clothes.SetActive(false);

        //print("hallo");
    }




    public void OnMouseDown()
    {
        Debug.Log("Button was pressed!");
    



    }

 
}
