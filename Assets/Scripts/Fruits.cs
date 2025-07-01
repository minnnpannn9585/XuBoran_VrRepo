using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    public Dictionary<int, Color> fruits = new Dictionary<int, Color>()
    {
        { 0, Color.red },    // Apple
        { 1, Color.yellow }, // Banana
        { 2, new Color(1, 0.5f, 0, 1) },  // orange
        { 3, new Color(0.5f, 0, 1, 1) },   // grape
    };

    // Color[] fruitColors;

    public int index;

}
