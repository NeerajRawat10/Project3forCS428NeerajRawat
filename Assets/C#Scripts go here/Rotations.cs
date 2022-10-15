using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotations : MonoBehaviour
{
    [SerializeField] private Vector3 _rotations;
    [SerializeField] private float _speeds;

    void Update()
    {
        transform.Rotate(_rotations * _speeds * Time.deltaTime);  
    }
}
