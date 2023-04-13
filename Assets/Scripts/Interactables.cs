using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interactables : MonoBehaviour
{
    /*
    public GameObject BenchZombie1;
    public GameObject BenchZombie2;

    public GameObject Bench1;
    public GameObject Bench2;

    public GameObject Lamp1;
    public GameObject Lamp2;
    */

    public PlayerScript player;
    public DialogueManager speech;

    public enum InteractionObject
    {
        nothing,
        info,
        dialogue
    }

    [Header("Which Interactable?")]
    public InteractionObject interactionObject;


    [Header("Short Info messages")]
    [TextArea]
    public string Info;
    private TMP_Text infoText;

    [Header("Initial Dialogue")]
    [TextArea]
    public string[] dialogue0;

    [Header("Quest Start Dialogue")]
    [TextArea]
    public string[] dialogue1;

    [Header("Quest Dialogue")]
    [TextArea]
    public string[] dialogue2;

    [Header("Final Dialogue")]
    [TextArea]
    public string[] dialogue3;

    [Header("Aftermath Dialogue")]
    [TextArea]
    public string[] dialogue4;

    public void Start()
    {
        infoText=GameObject.Find("Information").GetComponent<TMP_Text>();
    }

    public void Dialogue()
    {
        //player.transform.LookAt(transform.position);

        if (gameObject.CompareTag("Pumpkin") == true)
        {
            if (player.needCandle==false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue1);
                player.needCandle = true;
            }

            else if (player.needCandle==true &&player.hasCandle == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue2);

            }

            else if (player.hasCandle == true&&player.gotoMound==false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue3);

                player.gotoMound = true;
            }

            else if(player.gotoMound==true)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue4);

            }
        }

        if (gameObject.CompareTag("Vampire") == true)
        {
            

            if (player.needShovel==false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue0);
            }

            else if (player.needShovel == true&&player.needPlate==false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue1);

                player.needPlate = true;
            }

            else if (player.needShovel == true &&player.needPlate==true&&player.hasPlate==false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue2);

            }

            else if (player.hasShovel==false && player.hasPlate == true)
            {
                player.hasShovel = true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue3);

            }

            else if (player.hasShovel == true)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue4);

            }
        }

        if (gameObject.CompareTag("FenceZombie") == true)
        {
              FindObjectOfType<DialogueManager>().StartDialogue1(dialogue0);

        }

        if (gameObject.CompareTag("BenchZombie") == true)
        {

            if (player.needPlate == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue0);

            }

            else if (player.needPlate == true&&player.needFix==false)
            {
                player.needFix = true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue1);

            }

            else if (player.needPlate == true && player.needFix == true)
            {
                player.needFix = true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue2);

            }

        }

        if (gameObject.CompareTag("SittingZombie") == true)
        {
            if (player.hasFix == true && player.hasPlate == false)
            {
                player.hasPlate = true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue3);

            }

            else if (player.hasPlate == true)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue4);
            }
        }

        if (gameObject.CompareTag("DirtPatch") == true)
        {
            if (player.gotoMound == false)
            {
                Debug.Log("Neat");
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue0);
            }

            else if (player.gotoMound == true&&player.hasShovel==false)
            {
                player.needShovel = true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue1);

            }

            else if (player.hasShovel == true)
            {
                player.hasKey = true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue2);

            }

        }

        if (gameObject.CompareTag("Lamp") == true)
        {
            if (player.needCandle == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue0);

            }

            else if (player.needCandle == true && player.hasCandle==false)
            {
                player.hasCandle = true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue1);
            }

            else if (player.hasCandle == true)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue2);

            }
        }

        if (gameObject.CompareTag("Skeleton") == true)
        {
            if (player.needWood == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue0);

            }

            else if (player.needWood==true&& player.needSpins==false)
            {
                player.needSpins = true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue1);

            }

            else if (player.needSpins == true && player.hasSpins == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue2);

            }

            else if (player.hasSpins == true&&player.hasWood==false)
            {
                player.hasWood=true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue3);

            }

            else if (player.hasWood == true)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue4);

            }
        }

        if (gameObject.CompareTag("Repairman") == true)
        {
            if (player.needFix == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue0);

            }

            else if (player.needFix == true&&player.needWood==false)
            {
                player.needWood = true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue1);

            }

            else if (player.needWood == true&&player.hasWood==false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue2);

            }

            else if (player.hasWood == true && player.hasFix == false)
            {
                player.hasFix = true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue3);
            }

            else if (player.hasFix == true)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue4);

            }
        }

        if (gameObject.CompareTag("Gate") == true)
        {
            if (player.hasKey == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue0);
            }

            else if (player.hasKey == true)
            {
                player.WIN = true;
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue1);
            }
        }

        if (gameObject.CompareTag("WrongShovel") == true)
        {
            if (player.needShovel == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue0);
            }

            else if (player.needShovel== true&&player.hasKey==false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue1);

            }

            else if (player.hasKey == true)
            {
                FindObjectOfType<DialogueManager>().StartDialogue1(dialogue2);

            }
        }
    }

    public void LearnInfo()
    {
        StartCoroutine(InfoWait(Info, 3.0f));
    }

    IEnumerator InfoWait(string Info, float delay)
    {
        infoText.text = Info;
        yield return new WaitForSeconds(delay);
        infoText.text = null;
    }

}
