using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    //Static means this variable can be referenced from different scripts.
    public static float DistanceFromTarget;
    public float ToTarget;

    void Update()
    {
        RaycastHit Hit;
        if(Physics.Raycast (transform.position,transform.TransformDirection(Vector3.forward), out Hit))
        {
            ToTarget = Hit.distance;
            DistanceFromTarget = ToTarget;
        }
    }
}
