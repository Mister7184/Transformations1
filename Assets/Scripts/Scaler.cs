using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _maxScale;

    private void Update()
    {
        Vector3 newScale = transform.localScale;
        newScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;

        if(newScale.x <= _maxScale)
            transform.localScale = newScale;
    }
}
