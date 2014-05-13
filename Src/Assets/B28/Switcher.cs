using UnityEngine;
using System.Collections;

public class Switcher : MonoBehaviour {

	private void OnCollisionEnter(Collision col) 
    {
	    if (col.gameObject.name == "Switch")
	        GameObject.Find("Block").SendMessage("React");
    }
}
