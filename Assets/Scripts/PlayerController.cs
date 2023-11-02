using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector2 _playerDirection;
        float directionY = Input.GetAxisRaw("Vertical");
        _playerDirection.y = Mathf.Clamp(directionY, -3.75f, 3.75f);
        _rigidbody2D.velocity = new Vector2(0, _playerDirection.y * 15);
        _rigidbody2D.transform.position = new Vector2(_rigidbody2D.transform.position.x, Mathf.Clamp(_rigidbody2D.position.y, -3.75f, 3.75f));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
            GameManager.Lives--;
        }
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            GameManager.Coins += 30;
        }
        if (GameManager.Lives == 0)
            Destroy(_rigidbody2D.gameObject);
    }
    private void OnDestroy()
    {
        GameManager.Attempts++;
    }
}
