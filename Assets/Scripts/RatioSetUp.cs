using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatioSetUp : MonoBehaviour
{
    public int width, height;

    void Awake()
    {
        if (width == 0 || height == 0)
        {
            width = 600;
            height = 960;
        }
        Screen.SetResolution(width, height, false);
    }
}
