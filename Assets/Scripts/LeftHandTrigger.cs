using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandTrigger : MonoBehaviour
{
    WallManager wallManager;
    void Start()
    {
        wallManager = GameObject.Find("WallManager").GetComponent<WallManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LeftHandTrigger"))
        {
            wallManager.leftHandFinish = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("LeftHandTrigger"))
        {
            wallManager.leftHandFinish = false;
        }
    }
}
