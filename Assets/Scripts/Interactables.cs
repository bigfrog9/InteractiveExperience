using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interactables : MonoBehaviour
{
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
    public string[] dialogue1;

    [Header("Happy Dialogue")]
    [TextArea]
    public string[] dialogue2;

    [Header("Final Dialogue")]
    [TextArea]
    public string[] dialogue3;

    public void Start()
    {
        infoText=GameObject.Find("Information").GetComponent<TMP_Text>();
    }

    public void Dialogue()
    {

    }

    public void LearnInfo()
    {
        Debug.Log("Lol");
        infoText.text = Info;
    }
}
