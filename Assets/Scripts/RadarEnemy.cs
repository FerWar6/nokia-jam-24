using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarEnemy : MonoBehaviour
{
    public float moveSpeed = 0.01f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * moveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * moveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed);
        }
    }
}

