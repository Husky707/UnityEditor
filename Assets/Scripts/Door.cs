using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    [SerializeField] public bool isOpen = true;

    [Header("References")]
    [SerializeField] private Transform doorObj = null;
    [SerializeField] private Transform closePos = null;
    [SerializeField] private Transform openPos = null;


    public void OpenDoor()
    {
        if (isOpen)
            return;

        isOpen = true;
        doorObj.position = openPos.position;
    }

    public void CloseDoor()
    {
        if (!isOpen)
            return;

        isOpen = false;
        doorObj.position = closePos.position;
    }
}
