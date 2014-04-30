using UnityEngine;
using System.Collections;

public class createSpheres : MonoBehaviour {
    
	public Rigidbody myPrefab;
    private const float distanceMultiplier = 2f;

    private IEnumerator Start()
    {
        Vector3 pos = transform.position;
 
        for(int i=0; i<=3; i++)
        {
            Instantiate(myPrefab, new Vector3(pos.x + i * distanceMultiplier, pos.y, pos.z), transform.rotation);
            yield return new WaitForSeconds(0.5f);
            Debug.Log("made ball "+i);
        }
 
    }
}
