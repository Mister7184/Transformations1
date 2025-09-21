using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoverRotaterScaler : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _maxScale;

    void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);

        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);

        Vector3 newScale = transform.localScale;
        newScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;

        if (newScale.x <= _maxScale)
            transform.localScale = newScale;
    }
}
