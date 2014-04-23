using UnityEngine;

public class LightOn : MonoBehaviour
{
    void OnCollisionEnter(Collision myCollision) 
    {
        if(myCollision.gameObject.name == "Floor")
        {
            var myLight = (Light)GameObject.Find("Light").GetComponent(typeof(Light));
            myLight.enabled = true;
            myLight.intensity = 5;
        }

    }
}
