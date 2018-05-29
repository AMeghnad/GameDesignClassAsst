using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    enum Side
    {
        Left,
        Right
    }

    public float maxLeft, maxRight;
    public float playerSpeed;
    public GameObject particles;

    private Side wantedSide;

    // Use this for initialization
    void Awake()
    {
        wantedSide = Side.Left;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            switch (wantedSide)
            {
                case Side.Left:
                    wantedSide = Side.Right;
                    break;
                case Side.Right:
                    wantedSide = Side.Left;
                    break;
                default:
                    wantedSide = Side.Left;
                    break;
            }
        }
        SideSwap();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject clone = Instantiate(particles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void SideSwap()
    {
        float currentX = transform.position.x;
        switch (wantedSide)
        {
            case Side.Left:
                if (currentX > maxLeft)
                {
                    transform.Translate(-playerSpeed * Time.deltaTime,0,0);
                }
                break;
            case Side.Right:
                if (currentX < maxRight)
                {
                    transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
                }
                break;
            default:
                break;
        }
    }
}
