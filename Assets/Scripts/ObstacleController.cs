using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;

    void FixedUpdate()
    {
        Vector2 targetPosition = new Vector2(_rigidbody2D.position.x - 0.1f, _rigidbody2D.position.y);
        _rigidbody2D.MovePosition(targetPosition);
    }
}
