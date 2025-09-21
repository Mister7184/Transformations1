using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _minZ = 0f;
    [SerializeField] private float _maxZ = 1f;

    private bool _movingForward = true;

    private void Update()
    {
        if (_movingForward)
        {
            transform.position += new Vector3(0, 0, _speed * Time.deltaTime);

            if (transform.position.z >= _maxZ)
            {
                _movingForward = false;
            }
        }
        else
        {
            transform.position -= new Vector3(0, 0, _speed * Time.deltaTime);

            if (transform.position.z <= _minZ)
            {
                _movingForward = true;
            }  
        }
    }
}
