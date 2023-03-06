using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Transform _birdTransform;
    private Quaternion _startRotation;
    public AudioSource _birdAudioSource;
    private Vector3 downfallAngle = new Vector3(0f, 0f, -90f);
    private Vector3 _incrementAngle = new Vector3(0f, 0f, 1f);
    private ushort speed = 200;
    public static bool buttonClicked;
    public static Bird instance;

    private void Start()
    {
        instance = this;
        _rb = GetComponent<Rigidbody2D>();
        _birdTransform = GetComponent<Transform>();
        _startRotation = _birdTransform.rotation;
    }

    private void ResetRotation()
    {
        _birdTransform.rotation = _startRotation;
    }

    private void BirdRotation()
    {
        if (_birdTransform.rotation.z <= -90)
            _birdTransform.localEulerAngles = downfallAngle;
        else
        {
            _birdTransform.Rotate(0f, 0f, -1.5f);
        }

    }

    private void FixedUpdate()
    {
        //if (Input.GetButtonDown("Jump"))
        if (Input.GetMouseButtonDown(0))
        {
            ResetRotation();
            BirdJumps(Time.fixedDeltaTime);
        }

        BirdRotation();
    }

    public void BirdJumps(float deltaTime)
    {
        _birdAudioSource.Stop();
        _rb.velocity = Vector2.up * speed * deltaTime;
        _birdAudioSource.Play();
    }
}
