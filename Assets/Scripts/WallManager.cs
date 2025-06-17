using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    int index = 0;
    Transform currentWall;
    public bool leftHandFinish = false;
    public bool rightHandFinish = false;
    public bool headFinish = false;
    float timer = 3f;

    // Start is called before the first frame update
    void Start()
    {
        currentWall = transform.GetChild(index);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = 3f;
            if (leftHandFinish && rightHandFinish && headFinish)
            {
                index++;
                if (index >= transform.childCount)
                {
                    index = 0;
                }
                currentWall.gameObject.SetActive(false);
                currentWall = transform.GetChild(index);
                currentWall.gameObject.SetActive(true);

                leftHandFinish = false;
                rightHandFinish = false;
                headFinish = false;
            }
        }
    }
}
