using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Random = System.Random;

public class DialougeManager : MonoBehaviour
{
    public bool isRunning;

    public Dialouge activeDialouge;
    public static DialougeManager instance; // the single instance of inventory
    private Queue<string> sentences; //FIFO list

    public Animator dialougeDisplay;
    public Button nextButton;
    public TMP_Text nameText;
    public TMP_Text dialougeText;


    void Awake()
    {
        #region Singleton //Singleton instance
        if (instance == null)
        {
            instance = this; //if there is no current dialouge manager instance in game, occupy singleton with current dialouge manager class
        }
        else
        {
            Debug.LogWarning("More than one instance"); // otherwise there is already a dialouge manager instance in game, and no more can be created
            Destroy(gameObject);
            return;
        }
        #endregion
    }
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialouge(Dialouge dialouge)
    {
        dialougeDisplay.SetBool("isOpen", true);
        isRunning = true;
        dialougeText.text = ""; // clear text at the begining
        nextButton.enabled = false;
        nextButton.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        if (activeDialouge.canBeSkipped)
        {
            nextButton.GetComponentInChildren<TextMeshProUGUI>().text = "Skip";
        }
        activeDialouge = dialouge;
        nameText.text = activeDialouge.name;
        sentences.Clear(); //remove sentences from previous convo
        for (int i = 0; i < activeDialouge.sentences.Length; i += 1)
        {
            sentences.Enqueue(activeDialouge.sentences[i]); //add all sentences stored in dialouge class to Queue
        }

        StartCoroutine(DelayedStart(dialouge));
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0) //if there are no more sentences to be queued end the dialouge
        {
            EndDialouge();
        }
        else
        {
            if (sentences.Count == 1)
            {
                nextButton.GetComponentInChildren<TextMeshProUGUI>().text = "Finish";
            }
            else if (activeDialouge.canBeSkipped)
            {
                nextButton.GetComponentInChildren<TextMeshProUGUI>().text = "Skip";
            }
            else
            {
                nextButton.GetComponentInChildren<TextMeshProUGUI>().text = "Continue";
            }
            string displayString = sentences.Dequeue(); //grap the next value from the sentence Queue
            StopAllCoroutines();
            StartCoroutine(TypeSentence(displayString)); //begin the letter-by-letter display of dialouge
        }
    }
    public void EndDialouge()
    {
        dialougeDisplay.SetBool("isOpen", false);
        StartCoroutine(DelayedEnd());
    }

    IEnumerator DelayedStart(Dialouge dialouge) //gives time for dialouge panel to slide in before Dialouge is Typedl
    {
        yield return new WaitForSeconds(1f);
        DisplayNextSentence();
        yield return new WaitForSeconds(1f);
        nextButton.enabled = true;
        nextButton.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
    }
    IEnumerator DelayedEnd() //gives time for dialouge panel to slide out before you can re-trigger dialouge.
    {
        yield return new WaitForSeconds(0.5f);
        isRunning = false; // dialouge manager is no longer running
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialougeText.text = ""; // clear text at the begining
        if (!activeDialouge.canBeSkipped)
        {
            nextButton.enabled = false;
            nextButton.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        }
        else{
            nextButton.enabled = true;
            nextButton.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
        }

        char[] my_characters = sentence.ToCharArray(); //convert sentence into a string of characters

        foreach (char character in my_characters)
        { //loop through each character in sentence
            dialougeText.text += character; //add character by character to the dialougeText being displayed
            /*
            Random rng = new System.Random();
            bool randomBool = rng.Next(0, 2) > 0; //Play click or play audio randomly
            */
            yield return new WaitForSeconds(0.02f);//speed of dialouge appearance
        }

        yield return new WaitForSeconds(0.5f); // wait a bit after dialouge to display continue button
        nextButton.enabled = true;
        nextButton.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
    }
}
