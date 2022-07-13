using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public Vector3 range;

    private void LateUpdate()
    {
        transform.position = target.position + range;
    }
}
