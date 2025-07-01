using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject[] fruits;
    public float force;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ShootFruit();
        }
    }

    public void ShootFruit()
    {
        for(int i = 0; i < 10; i++)
        {
            Invoke("SpawnFruit", i * 0.5f);
            
        }
        
    }

    public void SpawnFruit()
    {
        GameObject fruit = Instantiate(fruits[Random.Range(0, fruits.Length)], transform.position, Quaternion.identity);
        fruit.GetComponent<Rigidbody>().AddForce(transform.right * force, ForceMode.Impulse);
    }
}
