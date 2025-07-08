using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HeadTrigger : MonoBehaviour
{
    //public Color[] wallColors;
    //public int index;
    

    WallManager wallManager;
    void Start()
    {
        //wallColors = new Color[5]
        //{
        //    Color.red,
        //    Color.yellow,
        //    new Color(1, 0.5f, 0, 1), // Orange
        //    new Color(0.5f, 0, 1, 1), // Purple
        //    new Color(0.17f, 0.38f, 0.08f, 1)
        //};
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
