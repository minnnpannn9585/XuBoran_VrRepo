using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTrigger : MonoBehaviour
{
    WallManager wallManager;
    void Start()
    {
        wallManager = GameObject.Find("WallManager").GetComponent<WallManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HeadTrigger"))
        {
            wallManager.headFinish = true;
            //Debug.Log("Left hand finished");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("HeadTrigger"))
        {
            wallManager.headFinish = false;
            //Debug.Log("Left hand not finished");
        }
    }
}
