using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resumeScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public void onClick()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
