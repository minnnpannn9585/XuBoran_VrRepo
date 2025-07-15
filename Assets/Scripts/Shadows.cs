using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadows : MonoBehaviour
{
    public Transform head;
    public Transform leftHand;
    public Transform rightHand;

    public int index;

    float shadowMaxZ = 0.1f;
    float shadowMinZ = 0.05f;
    float shadowMaxY = 7f;
    float shadowMinY = 4.3f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (index == 0)
        {
            transform.position = new Vector3(28.6f, head.position.y, head.position.z);

        }
        if (index == 1)
        {
            transform.position = new Vector3(28.6f, leftHand.position.y, leftHand.position.z);
        }
        if (index == 2)
        {
            transform.position = new Vector3(28.6f, rightHand.position.y, rightHand.position.z);
        }

        if (transform.position.y > shadowMaxY || transform.position.y < shadowMinY)
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, shadowMinY, shadowMaxY), transform.position.z);
        }
        //if

    }
}
