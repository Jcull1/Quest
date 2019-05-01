using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeSwing : MonoBehaviour
{
    public GameObject theAxe;
    public static bool isSwinging = false;
    public AudioSource swingSound;
    public static bool holdingAxe = false;

    void Update()
    {
        if (holdingAxe == true)
        {
            if (Input.GetButtonDown("Fire1") && isSwinging == false)
            {
                isSwinging = true;
                StartCoroutine(SwingTheAxe());

            }
        }
    }

    IEnumerator SwingTheAxe()
    {
        swingSound.Play();
        theAxe.GetComponent<Animation>().Play("SwingAxe");
        yield return new WaitForSeconds(1.0f);
        isSwinging = false;
    }
}
