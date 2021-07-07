using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private ball ball;
    private Vector3 offset;
    void Start()
    {
        ball = ball.Instance;
        offset = transform.position - ball.transform.position;
    }

    void LateUpdate()
    {
        transform.position = ball.transform.position + offset;
    }
}