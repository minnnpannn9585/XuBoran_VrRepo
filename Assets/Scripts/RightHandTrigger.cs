using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandTrigger : MonoBehaviour
{
    WallManager wallManager;
    void Start()
    {
        wallManager = GameObject.Find("WallManager").GetComponent<WallManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RightHandTrigger"))
        {
            wallManager.rightHandFinish = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RightHandTrigger"))
        {
            wallManager.rightHandFinish = false;
        }
    }
}
