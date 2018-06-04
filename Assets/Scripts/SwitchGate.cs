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

    void Start()
    {
        int randomGateNum = Random.Range(1, 11);
        if (randomGateNum > 5)
        {
            blockOne.SetActive(false);
        }
        else
        {
            blockTwo.SetActive(false);
        }
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
