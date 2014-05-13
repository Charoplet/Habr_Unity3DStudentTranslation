using System;
using UnityEngine;

public class move : MonoBehaviour {

	void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        transform.Translate(new Vector3(xMove,0,0));
	    transform.position = 
            new Vector3(Mathf.Clamp(transform.position.x, -10, 10), transform.position.y, transform.position.z);
    }
}
