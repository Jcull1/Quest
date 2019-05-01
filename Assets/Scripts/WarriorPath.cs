using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarriorPath : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCursor;
    public GameObject subText;
    public GameObject TextBox;
    public GameObject AreaBlock;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionDisplay.SetActive(true);
            ActionText.GetComponent<Text>().text = "Chat";
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
                if (DialogueState.stateAxeTake == false)
                {
                    TextBox.SetActive(true);
                    subText.GetComponent<Text>().text = "You're not ready to adventure to the wasteland.";
                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionDisplay.SetActive(false);
                    ActionText.SetActive(false);
                    ExtraCursor.SetActive(false);
                    StartCoroutine(ResetChat());
                }
                if (DialogueState.stateAxeTake == true)
                {
                    TextBox.SetActive(true);
                    AreaBlock.SetActive(false);
                    subText.GetComponent<Text>().text = "You found a weapon. Good luck!";
                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionDisplay.SetActive(false);
                    ActionText.SetActive(false);
                    ExtraCursor.SetActive(false);
                    StartCoroutine(ResetChat());
                }
            }
        }
    }

    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCursor.SetActive(false);
    }

    IEnumerator ResetChat()
    {
        yield return new WaitForSeconds(4.5f);
        TextBox.SetActive(false);
        subText.GetComponent<Text>().text = "";
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
