using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialogueManager : MonoBehaviour
{
    public GameObject panel;
    public TMP_Text Dialogue;

    public GameObject Player;

    private Queue<string> dialogue;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = new Queue<string>();
    }

    public void StartDialogue1(string[] sentences)
    {
        StopPlayer();
        dialogue.Clear();
        panel.SetActive(true);

        foreach(string currentLine in sentences)
        {
            dialogue.Enqueue(currentLine);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (dialogue.Count == 0)
        {
            EndDialogue();
            return;
        }

        string currentline = dialogue.Dequeue();

        Dialogue.text = currentline;
    }
    public void EndDialogue()
    {
        panel.SetActive(false);
        dialogue.Clear();

        Player.GetComponent<PlayerScript>().enabled = true;
        Player.GetComponent<Interaction>().enabled = true;
    }

    public void StopPlayer()
    {
        Player.GetComponent<PlayerScript>().enabled = false;
        Player.GetComponent<Interaction>().enabled = false;

        Player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Player.GetComponent<Rigidbody>().freezeRotation = true;

    }
}
