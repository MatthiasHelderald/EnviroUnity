using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    Camera cam;
    Vector3 pos = new Vector3(200, 200, 0);
    
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    
    [SerializeField] private Vector3 offset;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void LateUpdate()
    {
        Vector3 ray = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 desiredposition = ray + offset;
        transform.position = Vector3.SmoothDamp(transform.position,desiredposition,ref velocity,smoothTime);
    }
    
}
