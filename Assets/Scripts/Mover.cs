using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _minZ = 0f;
    [SerializeField] private float _maxZ = 1f;

    private bool _movingForward = true;

    private void Update()
    {
        if (_movingForward)
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);

            if (transform.position.z >= _maxZ)
            {
                _movingForward = false;
            }
        }
        else
        {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);

            if (transform.position.z <= _minZ)
            {
                _movingForward = true;
            }  
        }
    }
}
