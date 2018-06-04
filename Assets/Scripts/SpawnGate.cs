using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGate : MonoBehaviour
{
    public GameObject[] gates;
    public float gateDelay = 2.5f;

    private int randomGateNum;
    private int pastNum;
    private float currentDelay;

    void Start()
    {
        pastNum = -1;
        currentDelay = gateDelay;
    }

    void Update()
    {
        currentDelay += Time.deltaTime;
        if (currentDelay >= gateDelay)
        {
            randomGateNum = Random.Range(0, 3);
            while (randomGateNum == pastNum)
            {
                randomGateNum = Random.Range(0, 3);
            }
            Instantiate(gates[randomGateNum], transform.position, Quaternion.identity);
            pastNum = randomGateNum;
            currentDelay = 0;
        }
    }
}
