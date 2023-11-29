using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCompleted : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (StateNameConptroller.p4Solved && StateNameConptroller.p4Correct)
            {
                SceneManager.LoadScene("GoodEnd");
            }

            else if (StateNameConptroller.p4Solved && !StateNameConptroller.p4Correct )
            {
                SceneManager.LoadScene("BadEnd");
            }
        }
    }
}
