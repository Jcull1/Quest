﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamage : MonoBehaviour
{

    public int damageAmount = 5;
    public float targetDistance;
    public float allowedRange = 3.1f;
    public bool isAttacked = false;

    // Update is called once per frame
    void Update()
    {
        if(AxeSwing.holdingAxe == true)
        {
            if (Input.GetButtonDown("Fire1") && AxeSwing.isSwinging == false)
            {

                RaycastHit hit;
                if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit))
                {
                    targetDistance = hit.distance;
                    if(targetDistance <= allowedRange)
                    {
                        isAttacked = true;
                        hit.transform.SendMessage("DeductDamage", damageAmount, SendMessageOptions.DontRequireReceiver);
                    }
                }
            }
        }
    }
}
