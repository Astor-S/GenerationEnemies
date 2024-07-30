using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private void Update()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }
}