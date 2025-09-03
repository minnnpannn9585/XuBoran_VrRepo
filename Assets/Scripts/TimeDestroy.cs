using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroy : MonoBehaviour
{
    public float timeToDestroy = 10f;
    
    void Update()
    {
        timeToDestroy -= Time.deltaTime;
        if (timeToDestroy <= 0f)
            Destroy(gameObject);  
    }
}
