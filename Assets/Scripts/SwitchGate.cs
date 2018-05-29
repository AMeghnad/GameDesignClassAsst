using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGate : Gate
{
    public GameObject blockOne, blockTwo;

    enum Side
    {
        Left,
        Right
    }

    void Awake()
    {

    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            blockOne.SetActive(!blockOne.activeSelf);
            blockTwo.SetActive(!blockTwo.activeSelf);
        }
    }
}
