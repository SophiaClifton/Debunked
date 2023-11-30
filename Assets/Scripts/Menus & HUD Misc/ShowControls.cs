using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControls : MonoBehaviour
{
    public bool showControls = false;

    // Update is called once per frame
    void Update()
    {
        //Check if Options is opened or not
        if (showControls == true)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);

            }
        }
        if (showControls == false)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);

            }
        }
    }

    public void OpenControls()
    {
        showControls = true;
    }

    public void CloseControls()
    {
        showControls = false;
    }
}
