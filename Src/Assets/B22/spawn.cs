using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour
{
    public GameObject box;
    private bool readynow = true;
 
    private void Update()
    {
        if (readynow)
            StartCoroutine(MakeBox());
    }
 
    private IEnumerator MakeBox()
    {
     readynow = false;
     Instantiate(box, transform.position, transform.rotation);
     yield return new WaitForSeconds(2);
     readynow = true;
    }
}
