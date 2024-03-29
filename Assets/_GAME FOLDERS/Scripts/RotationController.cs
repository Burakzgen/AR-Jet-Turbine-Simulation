using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] Vector3 _rotation;

    private void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }
}
