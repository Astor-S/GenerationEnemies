using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void SetDirection(Vector3 direction)
    {
        transform.forward = direction;
    }
}