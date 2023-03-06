using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private Transform _groundTransform;
    private Vector3 _startPosition;
    public float endX;  //set value in unity
    public static float speed = 3.1f;   //value uses in PipeMove.cs

    // Start is called before the first frame update
    void Start()
    {
        _groundTransform = GetComponent<Transform>();
        _startPosition = _groundTransform.position;
    }

    private void GroundMove(float fixedDeltaTime)
    {
        _groundTransform.position += Vector3.left * speed * fixedDeltaTime;
        
        if (_groundTransform.position.x <= endX)
            GroundReset();
    }

    private void GroundReset()
    {
        _groundTransform.position = _startPosition;
    }

    private void FixedUpdate()
    {
        GroundMove(Time.fixedDeltaTime);
    }
}
