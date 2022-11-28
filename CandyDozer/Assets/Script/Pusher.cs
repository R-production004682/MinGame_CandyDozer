using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
   
    public float pushDistance;
    public float _speed;

    Vector3 _position;

    void Start()
    {
        _position = transform.localPosition;
    }

    void Update()
    {
        var distance_Z = pushDistance * Mathf.Cos(_speed * Time.time);
        

        transform.localPosition = _position + new Vector3(0,0,distance_Z);
    }

  
}
