using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public Transform playerCam;
    public Vector2 sensitivity;
    private Vector2 xyRotation;
    public bool paused;
    public GameObject Canvas;
    public canvasScript CanvasScript;
    void Start()
    {
        // Invisible cursor to the middle of the screen
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;

        CanvasScript = Canvas.GetComponent<canvasScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CanvasScript != null) 
        {
            paused = CanvasScript.paused;
        }
        
        Vector2 MouseInput = new Vector2
        {
            x = Input.GetAxis("Mouse X"),
            y = Input.GetAxis("Mouse Y")
        };
        
            if(true)
            {
                //Debug.Log(paused);
                xyRotation.x -= MouseInput.y * sensitivity.y;
                xyRotation.y += MouseInput.x * sensitivity.x;

                xyRotation.x = Mathf.Clamp(xyRotation.x, -90f, 90f);

                transform.eulerAngles = new Vector3(0f, xyRotation.y, 0f);
                playerCam.localEulerAngles = new Vector3(xyRotation.x, 0f, 0f); 
            }
        
    }
}
