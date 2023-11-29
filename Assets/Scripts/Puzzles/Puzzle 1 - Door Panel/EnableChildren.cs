using UnityEngine;

public class EnableChildren : MonoBehaviour
{
    private bool done = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !done)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        if (StateNameConptroller.p1Solved == true)
        {
            done = true;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
