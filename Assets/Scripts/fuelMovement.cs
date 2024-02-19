using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelMovement : MonoBehaviour
{
    public int fuelAmount;
    public float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(input, 0, 0) * movementSpeed * Time.deltaTime;

        transform.Translate(movement);
    }
}
