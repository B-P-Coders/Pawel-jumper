using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform transform;
    [SerializeField]
    private Transform Target;
    public float CameraSpeed;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(Target.position.x, Target.position.y, transform.position.z), CameraSpeed * Time.fixedDeltaTime);
    }
}
