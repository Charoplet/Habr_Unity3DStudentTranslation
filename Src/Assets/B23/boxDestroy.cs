using UnityEngine;
using System.Collections;

public class boxDestroy : MonoBehaviour {

    public ParticleSystem stars;

    private void OnCollisionEnter(Collision col)
    {
        Instantiate(stars, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
