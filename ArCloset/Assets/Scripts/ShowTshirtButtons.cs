using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTshirtButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject t1 = GameObject.Find("AddTshirt1");
        t1.SetActive(false);
        GameObject t2 = GameObject.Find("AddTshirt2");
        t2.SetActive(false);
        GameObject sw1 = GameObject.Find("AddSweater1");
        sw1.SetActive(false);
        GameObject sw2 = GameObject.Find("AddSweater2");
        sw2.SetActive(false);
        GameObject p1 = GameObject.Find("AddPants1");
        p1.SetActive(false);
        GameObject p2 = GameObject.Find("AddPants2");
        p2.SetActive(false);
        GameObject sh1 = GameObject.Find("AddShoes1");
        sh1.SetActive(false);
        GameObject sh2 = GameObject.Find("AddShoes2");
        sh2.SetActive(false);




    }


}
