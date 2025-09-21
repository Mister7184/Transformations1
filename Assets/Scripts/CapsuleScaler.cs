using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _maxScale;

    void Update()
    {
        Vector3 newScale = transform.localScale;
        newScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;

        if(newScale.x <= _maxScale)
            transform.localScale = newScale;
    }
}
