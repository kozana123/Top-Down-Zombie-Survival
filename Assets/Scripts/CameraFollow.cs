using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed = 1;

     private Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.transform.position;
    }

    private void LateUpdate()
    {
        //Vector3 targetPosition = target.transform.position - offset;

        transform.position = Vector3.Lerp(transform.position, offset + target.transform.position, speed);

    }
}
