using UnityEngine;
using System.Collections;

public class SwitchLight : MonoBehaviour 
{

    public Transform box;

    private const int cMaxDistance = 10;

    private void Update()
    {

        //вариант 1
        //float dist = Vector3.Distance(box.position, transform.position);
        //Debug.Log(dist);

        //if (dist <= 10)             //вместо if/else можно использовать более сокращенную запись: light.enabled = dist <= 10;
        //{
        //    light.enabled = true;
        //}
        //else
        //{
        //    light.enabled = false;
        //}

        //вариант 2
        //float dist = (box.position - transform.position).magnitude;
        //light.enabled = dist <= cMaxDistance;
        //Debug.Log(dist);

        //вариант 3 - оптимизированный
        float dist = (box.position - transform.position).sqrMagnitude;
        light.enabled = dist <= cMaxDistance * cMaxDistance;
        Debug.Log(dist);

    }
}
