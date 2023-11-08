using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasScript : MonoBehaviour
{
    public Transform playerTransform;
    public float distanceFromPlayer = 2.0f;
    public GameObject pauseMenu;
    public bool paused = false;
    void Update()
    {
        // Calculate the canvas position in front of the player
        Vector3 canvasPosition = playerTransform.position + playerTransform.forward * distanceFromPlayer;
        canvasPosition.y+=1;
        transform.position = canvasPosition;

        // Make the canvas face the same direction as the player
        transform.forward = playerTransform.forward;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(paused);
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            paused=true;
            Debug.Log(paused);
        }
    }
}
