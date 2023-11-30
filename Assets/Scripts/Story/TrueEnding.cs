using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrueEnding : MonoBehaviour
{
    public TMP_Text line;
    public AudioSource sound;
    private int lineCount = 0;

    private float time = 3;
    private float textSpeed = 0.08f;

    //Scripts
    private string[] trueEndingScript = { "Detective Bean: “It’s no use…”", "Detective Bean: “I’m-”" };
    private string[] badEndingScript = { "End 2" };

    private void Start()
    {
        line.text = string.Empty;
        StartCoroutine(Timer());
        StartDialogue();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (line.text == trueEndingScript[lineCount])
            {
                ChangeLine();
            }
            else
            {
                StopAllCoroutines();
                line.text = trueEndingScript[lineCount];
            }
        }
    }

    private void StartDialogue()
    {
        lineCount = 0;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine()
    {
        foreach (char c in trueEndingScript[lineCount].ToCharArray())
        {
            line.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        StopAllCoroutines();
    }

    void ChangeLine()
    {
        if (lineCount < (trueEndingScript.Length - 1))
        {
            lineCount++;
            line.text = string.Empty;
            StartCoroutine(ShowLine());
        }
        else
        {
            sound.Play();
            gameObject.SetActive(false);
        }
    }
}
