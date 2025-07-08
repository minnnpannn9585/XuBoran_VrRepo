using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandColorChange : MonoBehaviour
{
    public int index;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Fruit")
        {
            transform.GetChild(0).GetComponent<MeshRenderer>().material.color = other.GetComponent<Fruits>().fruits[other.GetComponent<Fruits>().index];
            index = other.GetComponent<Fruits>().index;
        }
    }
}
