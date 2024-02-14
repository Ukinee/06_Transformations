using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(0, Time.deltaTime * _speed, 0);
    }
}
