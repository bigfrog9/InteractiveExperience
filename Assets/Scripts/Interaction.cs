using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField]
    private GameObject interactionObj = null;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("TreeTrunk") == true)
        {
            interactionObj=other.gameObject;
        }
        
        else if (other.CompareTag("DirtPatch") == true)
        {
            interactionObj=other.gameObject;
        }

        else if (other.CompareTag("Lamp") == true)
        {
            interactionObj = other.gameObject;
        }

        else if (other.CompareTag("Gate") == true)
        {
            interactionObj = other.gameObject;
        }

        else if (other.CompareTag("Grave1") == true)
        {
            interactionObj = other.gameObject;
        }

        else if (other.CompareTag("Grave2") == true)
        {
            interactionObj = other.gameObject;
        }

        else if (other.CompareTag("Grave3") == true)
        {
            interactionObj = other.gameObject;
        }

        else if (other.CompareTag("Grave4") == true)
        {
            interactionObj = other.gameObject;
        }

        else if (other.CompareTag("Vampire") == true)
        {
            interactionObj = other.gameObject;
        }

        else if (other.CompareTag("FenceZombie") == true)
        {
            interactionObj = other.gameObject;
        }

        else if (other.CompareTag("Skeleton") == true)
        {
            interactionObj = other.gameObject;
        }

        else if (other.CompareTag("BenchZombie") == true)
        {
            interactionObj = other.gameObject;
        }

        else if (other.CompareTag("Pumpkin") == true)
        {
            interactionObj = other.gameObject;
        }
    }
}
