using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpenHouse1 : MonoBehaviour
{
    public GameObject theDoor;
    public AudioSource creakSound;

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCursor;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionDisplay.SetActive(true);
            ActionText.GetComponent<Text>().text = "Open Door.";
            ActionText.SetActive(true);
            ExtraCursor.SetActive(true);
        }
        else
        {
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCursor.SetActive(false);
        }

        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 3)
            {
                creakSound.Play();
                theDoor.GetComponent<Animator>().Play("OpenDoorVillageOne");
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCursor.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCursor.SetActive(false);
    }
}
