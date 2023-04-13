using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField]
    private GameObject interactionObj = null;

    public Interactables interactables;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&interactionObj!=null)
        {
            Debug.Log("ayyy");
            CurrentInteraction();
        }
    }

    public void CurrentInteraction()
    {
        if (interactables.interactionObject == Interactables.InteractionObject.info)
        {
            interactables.LearnInfo();
        }

        else if (interactables.interactionObject == Interactables.InteractionObject.dialogue)
        {
            interactables.Dialogue();
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Info") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();
        }

        else if (other.CompareTag("TreeTrunk") == true)
        {
            interactionObj=other.gameObject;
            interactables=interactionObj.GetComponent<Interactables>();
        }
        
        else if (other.CompareTag("DirtPatch") == true)
        {
            interactionObj=other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }

        else if (other.CompareTag("Lamp") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }

        else if (other.CompareTag("Gate") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }

        else if (other.CompareTag("Grave1") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }

        else if (other.CompareTag("Grave2") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }

        else if (other.CompareTag("Grave3") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }

        else if (other.CompareTag("Vampire") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }

        else if (other.CompareTag("FenceZombie") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }

        else if (other.CompareTag("Skeleton") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }

        else if (other.CompareTag("BenchZombie") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }

        else if (other.CompareTag("SittingZombie") == true)
        {
            interactionObj = other.gameObject;
            interactables=interactionObj.GetComponent<Interactables>();
        }

        else if (other.CompareTag("Pumpkin") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }
        
        else if (other.CompareTag("Repairman") == true)
        {
            interactionObj = other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();

        }

        else if (other.CompareTag("WrongShovel") == true)
        {
            interactionObj= other.gameObject;
            interactables = interactionObj.GetComponent<Interactables>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TreeTrunk") == true)
        {
            interactionObj = null;
            interactables = null;

        }

        else if (other.CompareTag("DirtPatch") == true)
        {
            interactionObj = null;
            interactables = null;

        }

        else if (other.CompareTag("Lamp") == true)
        {
            interactionObj = null;
            interactables = null;
        }

        else if (other.CompareTag("Gate") == true)
        {
            interactionObj = null;
            interactables = null;
        }

        else if (other.CompareTag("Grave1") == true)
        {
            interactionObj = null;
            interactables = null;
        }

        else if (other.CompareTag("Grave2") == true)
        {
            interactionObj = null;
            interactables = null;
        }

        else if (other.CompareTag("Grave3") == true)
        {
            interactionObj = null;
            interactables = null;
        }

        else if (other.CompareTag("Vampire") == true)
        {
            interactionObj = null;
            interactables = null;
        }

        else if (other.CompareTag("FenceZombie") == true)
        {
            interactionObj = null;
            interactables = null;
        }

        else if (other.CompareTag("Skeleton") == true)
        {
            interactionObj = null;
            interactables = null;
        }

        else if (other.CompareTag("BenchZombie") == true)
        {
            interactionObj = null;
            interactables = null;
        }

        else if (other.CompareTag("Pumpkin") == true)
        {
            interactionObj = null;
            interactables = null;
        }
        
        else if (other.CompareTag("Repairman") == true)
        {
            interactionObj = null;
            interactables = null;
        }
    }
}
