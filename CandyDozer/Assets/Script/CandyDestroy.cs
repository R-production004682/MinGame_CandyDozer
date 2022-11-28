using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroy : MonoBehaviour
{
    public string tagName = "Candy";

    void OnTriggerEnter(Collider candy)
    {
       if(candy.gameObject.tag == tagName)
       {
            Destroy(candy.gameObject);
       }
    }
}
