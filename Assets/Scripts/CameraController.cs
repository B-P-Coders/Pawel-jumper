using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform transform;
    [SerializeField]
    private Transform Target;
    public float CameraSpeed;
    [SerializeField] 
    private Vector3 offset;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, new Vector3(Target.position.x, Target.position.y, transform.position.z), CameraSpeed * Time.fixedDeltaTime) + offset;
    }
}
