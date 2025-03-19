using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    [SerializeField]
    private GameObject trackObject;

    [SerializeField]
    private float speed = 500f;


    private Vector3 trackPos;

    private float mouseInputX;

    private void Start()
    {
        trackPos = trackObject.transform.position;
    }

    void Update()
    {
        transform.position += trackObject.transform.position - trackPos;
        trackPos = trackObject.transform.position;

        mouseInputX = Input.GetAxis("Mouse X");
        transform.RotateAround(trackPos, Vector3.up, mouseInputX * Time.deltaTime * speed);
    }
}
