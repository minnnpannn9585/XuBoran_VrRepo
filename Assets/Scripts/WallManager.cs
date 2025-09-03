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
    public int passedLevels = 0;
    public Cannon cannon;
    public GameManager gm;

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
                PassThisLevel();
            }
        }
    }

    public void PassThisLevel()
    {
        passedLevels++;
        index++;
        gm.ResetLevelCountdown();

        if (index >= 5)
        {
            foreach (GameObject fruit in cannon.existingFruits)
            {

                Destroy(fruit);
            }
        }
        if (index >= 4)
        {
            cannon.ShootFruit();
        }
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
