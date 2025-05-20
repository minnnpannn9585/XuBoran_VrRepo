using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadows : MonoBehaviour
{
    public Transform head;
    public Transform leftHand;
    public Transform rightHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetChild(0).position = new Vector3(head.position.x, head.position.y, 2.8f);
    }
}
