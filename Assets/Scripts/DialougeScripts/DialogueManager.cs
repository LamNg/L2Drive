using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System.Diagnostics;
using System.IO;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;

    public Animator animator;
    Stopwatch stopwatch = new Stopwatch();

    private Queue<string> sentences;

    // Use this for initialization
    void Start()
    {
        sentences = new Queue<string>();
        print("starting timer");
        stopwatch.Start();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        animator.SetBool("IsOpen", false);
        SceneManager.LoadScene(buttonName);
        timeStamp();
    }

    public void timeStamp()
    {
        string text = SceneManager.GetActiveScene().name + " took " + stopwatch.Elapsed + " seconds";
        TextWriter textWriter = new StreamWriter(@"textfile.txt", true);
        textWriter.WriteLine(text);
        textWriter.Close();
        print(text);
        stopwatch.Stop();
    }

}
