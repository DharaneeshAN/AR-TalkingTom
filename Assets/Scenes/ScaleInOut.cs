using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleInOut : MonoBehaviour
{
    public GameObject Object; // The object to scale
    public float Scale = 0.001f; // Amount to scale by each button press

    // Increase object scale by a specific amount
    public void OnPressZoomIn()
    {
        Object.transform.localScale += new Vector3(Scale, Scale, Scale);
    }

    // Decrease object scale by a specific amount
    public void OnPressZoomOut()
    {
        Object.transform.localScale -= new Vector3(Scale, Scale, Scale);
    }
}