using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _targetScaleFactor;

    private Vector3 _targetScale;
    
    private void Start()
    {
        _targetScale = Vector3.one * _targetScaleFactor;
    }

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale,
            _targetScale, _speed * Time.deltaTime);
    }
}
