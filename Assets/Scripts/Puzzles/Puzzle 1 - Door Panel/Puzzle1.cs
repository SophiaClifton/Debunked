using TMPro;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public AudioSource incorrectSound;
    public AudioSource doorSound;

    private string input = "Wendy";
    public TMP_InputField userInput;
    
    void Update()
    {
        input = input.ToLower();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (input.CompareTo(userInput.text.ToLower()) == 0)
            {
                doorSound.Play();
                StateNameConptroller.p1Solved = true;
                StateNameConptroller.p1Correct = true;
            }
            else
            {
                incorrectSound.Play();
                StateNameConptroller.p1tries += 1;
            }
        }

        if(StateNameConptroller.p1tries == 3)
        {
            StateNameConptroller.p1Solved = true;
        }
    }
}
