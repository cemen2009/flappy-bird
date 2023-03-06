using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    private Transform _pipeTransform;

    // Start is called before the first frame update
    void Start()
    {
        _pipeTransform = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        _pipeTransform.position += Vector3.left * Ground.speed * Time.deltaTime;
    }
}
