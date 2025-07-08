using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandTrigger : MonoBehaviour
{
    public Color[] wallColors;
    public int index;
    WallManager wallManager;
    void Start()
    {
        wallColors = new Color[5]
        {
            Color.red,
            Color.yellow,
            new Color(1, 0.5f, 0, 1), // Orange
            new Color(0.5f, 0, 1, 1), // Purple
            new Color(0.17f, 0.38f, 0.08f, 1)
        };
        wallManager = GameObject.Find("WallManager").GetComponent<WallManager>();
    }
    private void Update()
    {
        wallManager.leftHandFinish = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LeftHandTrigger"))
        {
            if (this.index == other.GetComponent<LeftHandColorChange>().index)
            {
                wallManager.leftHandFinish = true;
            }
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
