using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelMovement : MonoBehaviour
{
    public int fuelAmount;

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(input, 4, 0)
    }
}
