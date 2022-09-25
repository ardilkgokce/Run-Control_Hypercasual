using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 targetOfset;
    void Start()
    {
        targetOfset = transform.position - target.transform.position;
    }


    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + targetOfset, 0.125f);


    }
}
