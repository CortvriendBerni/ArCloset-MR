using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideClothesAvatar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject t1 = GameObject.Find("tshirt_white");
        t1.SetActive(false);
        GameObject t2 = GameObject.Find("tights_black");
        t2.SetActive(false);
        GameObject sw1 = GameObject.Find("sportpants_grey");
        sw1.SetActive(false);
        GameObject sw2 = GameObject.Find("shoes_tall");
        sw2.SetActive(false);
        GameObject p1 = GameObject.Find("shoe_low_white");
        p1.SetActive(false);
        GameObject p2 = GameObject.Find("male_tanktop_yellow");
        p2.SetActive(false);
        GameObject sh1 = GameObject.Find("hoodie_grey");
        sh1.SetActive(false);
        GameObject sh2 = GameObject.Find("hoodie_blue");
        sh2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
