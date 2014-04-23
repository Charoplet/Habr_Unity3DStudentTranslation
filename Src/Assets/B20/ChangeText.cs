using UnityEngine;
using System.Collections;

public class ChangeText : MonoBehaviour {

	bool myCheck = true;
 
    void Update()
    {
        if(myCheck)
        {
            guiText.text = "Its on!";
        }
        else
        {
            guiText.text = "Its Off!";
        }

        if(Input.GetButtonUp("Jump") && myCheck)
        {
            myCheck = false;
            
        }
        else if(Input.GetButtonUp("Jump") && !myCheck)
        {
            myCheck = true;
        }
    }
}
