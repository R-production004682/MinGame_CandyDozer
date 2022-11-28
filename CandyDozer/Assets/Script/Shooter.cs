using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject[] arrayCandy;
    public Transform _transform;

    public float shotPower;
    public float shotTprque;
    public float baseWidth;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shot();
        }
    }

    GameObject SampleCandy()
    {
        var index = Random.Range(0 , arrayCandy.Length);
        return arrayCandy[index];
    }

    Vector3 GetInstantiatePosition()
    {
        var x = baseWidth * (Input.mousePosition.x / Screen.width) * (baseWidth / 2);
        return transform.position + new Vector3(x , 0 ,0);
    }

    public void Shot()
    {
        GameObject candy = (GameObject)Instantiate(SampleCandy() , 
                               GetInstantiatePosition() , Quaternion.identity);

        candy.transform.parent = _transform;

        Rigidbody rb = candy.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * shotPower);
        rb.AddTorque(new Vector3(0,shotTprque , 0));

    }


}
