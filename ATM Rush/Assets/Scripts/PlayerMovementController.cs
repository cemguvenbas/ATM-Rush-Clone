using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float horizontalSpeed;

    private float horizontalInput;

    private void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput * horizontalSpeed * Time.deltaTime,0,movementSpeed * Time.deltaTime));
    }
}
