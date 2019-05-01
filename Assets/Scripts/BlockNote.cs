using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockNote : MonoBehaviour
{
    public GameObject blockNote;

    private void OnTriggerEnter(Collider other)
    {
        blockNote.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        blockNote.SetActive(false);
    }
}
