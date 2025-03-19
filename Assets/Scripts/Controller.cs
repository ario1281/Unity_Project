using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    private Rigidbody _rigidbody;

    private Vector3 inputMove = Vector3.zero;
    private Vector3 camForward;
    private Vector3 movForward;

    void Start()
    {
        TryGetComponent(out _rigidbody);
    }

    void Update()
    {
        inputMove.x = Input.GetAxis("Horizontal");
        inputMove.z = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        var mainCam = Camera.main;
        camForward = Vector3.Scale(mainCam.transform.forward, new Vector3(1,0,1)).normalized;
        movForward = camForward * inputMove.z + mainCam.transform.right * inputMove.x;
        _rigidbody.velocity = movForward * speed + new Vector3(0, _rigidbody.velocity.y, 0);

        if (movForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movForward);
        }
    }
}
