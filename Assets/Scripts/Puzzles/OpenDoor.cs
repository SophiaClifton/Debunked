using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public MyDoorController doorScript;
 
    void Update()
    {
        if (StateNameConptroller.p1Correct == true && StateNameConptroller.doOnce == false)
        {
            doorScript.doorOpen=true;
            doorScript.PlayAnimation();
            StateNameConptroller.doOnce = true;
        }
        
    }
}
