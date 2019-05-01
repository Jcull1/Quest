using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
    public int rotateSpeed;
    public AudioSource collectSound;
    public GameObject gem;

     void Update()
    {
        transform.Rotate(0, rotateSpeed, 0,Space.World);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        gem.SetActive(false);
    }*/
}
