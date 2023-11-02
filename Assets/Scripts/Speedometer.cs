using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedometer : MonoBehaviour
{
    [SerializeField] private Rigidbody2D target;

    [SerializeField] private float maxSpeed = 0.0f;

    [SerializeField] private float minSpeedArrowAngle;
    [SerializeField] private float maxSpeedArrowAngle;

    [SerializeField] private RectTransform arrow;

    [SerializeField] private float speed = 0.0f;
    private void Update()
    {
        speed = target.velocity.magnitude * 3.6f;

        if (arrow != null)
            arrow.localEulerAngles =
                new Vector3(0, 0, Mathf.Lerp(minSpeedArrowAngle, maxSpeedArrowAngle, speed / maxSpeed));
    }
}
