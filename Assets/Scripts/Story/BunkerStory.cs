using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BunkerStory : MonoBehaviour
{
    public TMP_Text line;
    public AudioSource sound;
    private int bunkerLineCount = 0;

    private float time = 3;
    private float textSpeed = 0.08f;

    //Scripts
    private string[] bunkerScript = { "Detective Bean: “Anna...!”",
                                      "Anna: “H-Help…Please…”",
                                      "Detective Bean: “Don’t worry, I’m gonna get you out of-”",
                                      "Mysterious Voice:“Not so fast, detective.”",
                                      "Detective Bean: “What…?”",
                                      "Mysterious Voice: “It’d be a shame for this to end so quickly after all the prep-work I had to do.”",
                                      "This voice-",
                                      "Mysterious Voice: “Though, if you want to end this scene with a bang, I suppose that’s alright as well.”",
                                      "-it's all too familiar.",
                                      "Detective Bean: “A bang? What do you-”",
                                      "Mysterious Voice: “But I’m sure you’d rather leave here with her alive, yes?”",
                                      "Anna: “I don’t wanna die… I don’t wanna die…”",
                                      "Mysterious Voice: “To save Anna, you must complete all of the games I’ve set up for you in this room.”",
                                      "Mysterious Voice: “Each game is directly linked to a restraint on one of Anna’s limbs. Successfully complete a game, and the linked limb will pop free.”",
                                      "Mysterious Voice: “Fail and, well…bang.”",
                                      "Mysterious Voice: “Don’t worry though, I’ll give you a few chances. It’d be a shame to let all this work go to waste, after all.”",
                                      "Mysterious Voice: “Once you’ve either freed [Anna] or they’ve succumbed to a more *unfortunate* fate, you’ll need to answer my initial riddle in order to open the door.”",
                                      "Mysterious Voice: “All the information you need is in this room.”",
                                      "Mysterious Voice: “So detective…Who am I?”",
                                      "Detective Bean: “Don’t worry, I promise I’ll get you out of here alive.”",
                                      "Detective Bean: “But to do that, I’m going to need your help.”",
                                      "Anna: “O-Okay.”",
                                      "Detective Bean: “Good. I’m going to check out these supposed ‘games’ that have been set up. So for now, just sit tight.”",
                                      ""
                                    };

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
            if (line.text == bunkerScript[bunkerLineCount])
            {
                ChangeLine();
            }
            else
            {
                StopAllCoroutines();
                line.text =bunkerScript[bunkerLineCount];
            }
        }
    }

    private void StartDialogue()
    {
        bunkerLineCount = 0;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine()
    {
        foreach (char c in bunkerScript[bunkerLineCount].ToCharArray())
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
        if (bunkerLineCount < (bunkerScript.Length - 1))
        {
            bunkerLineCount++;
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
