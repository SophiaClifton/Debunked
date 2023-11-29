using UnityEngine;

public class DisableDoorAccess : MonoBehaviour
{
    void Update()
    {
        if (StateNameConptroller.p1Solved == true && StateNameConptroller.p1Correct == false)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
