using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelScript : MonoBehaviour
{
    public Transform car;
    public Vector3 offset;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = car.position + offset;
    }
}
