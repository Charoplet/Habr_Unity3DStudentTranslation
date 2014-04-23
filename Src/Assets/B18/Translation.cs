using UnityEngine;
using System.Collections;

public class Translation : MonoBehaviour {

	
	// Update is called once per frame
	void Update() 
    {
        //transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
	    Vector3 fwd = transform.forward * 100;
        rigidbody.AddForce(fwd);

	}
}
