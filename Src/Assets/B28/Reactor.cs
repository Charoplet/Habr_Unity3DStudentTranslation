using UnityEngine;
using System.Collections;

public class Reactor : MonoBehaviour {

	public Texture2D downTexture;
 
    private IEnumerator React() 
    {
        renderer.material.mainTexture = downTexture;
        yield return new WaitForSeconds(1);
        gameObject.AddComponent(typeof(Rigidbody));
    }
}
