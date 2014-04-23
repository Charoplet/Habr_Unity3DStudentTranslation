using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {


    public Transform myTransform;

    void Update() 
    { 
        transform.LookAt(myTransform); 
    }
}
