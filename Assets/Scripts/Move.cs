using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Vector3 _direction;

    void Awake()
    {
        _direction = transform.forward;
    }

    void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}