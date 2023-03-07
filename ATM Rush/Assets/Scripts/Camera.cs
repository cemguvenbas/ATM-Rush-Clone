using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,target.position + offset,Time.deltaTime * 2);
    }
}
