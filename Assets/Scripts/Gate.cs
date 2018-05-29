using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public float gateSpeed, endPoint;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -gateSpeed * Time.deltaTime, 0);
        if (transform.position.y <= endPoint)
        {
            Destroy(gameObject);
        }
    }
}
