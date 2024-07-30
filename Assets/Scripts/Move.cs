using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private void Update()
    {
        Vector3 direction = transform.forward;
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}