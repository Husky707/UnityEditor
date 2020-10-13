using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent OnInteract;


    public void Interact()
    {
        OnInteract.Invoke();
    }

    bool isValidTrigger(string testTag)
    {
        if (testTag == "default")
            return true;

        return false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(isValidTrigger(other.gameObject.tag))
        {
            Interact();
        }
    }
}
