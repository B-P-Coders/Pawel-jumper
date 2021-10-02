using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField]
    private Transform[] Levels = new Transform[3];
    [SerializeField]
    private GameObject[] Platforms = new GameObject[3];
    private Transform transform;
    private Vector3 startPosition;
    [SerializeField]
    private Vector3 distance;
    [SerializeField]
    private Transform placeholder;

    void Start()
    {
        transform = GetComponent<Transform>();
        startPosition = transform.position;
    }

    void Update()
    {
        if (startPosition.y + distance.y < transform.position.y) generatePlatform();
    }

    private void generatePlatform()
    {
        int platformId = Random.Range(0, 2);
        int levelId = Random.Range(0, 2);
        Instantiate(Platforms[platformId], Levels[levelId].position, Quaternion.identity, placeholder);
        startPosition = transform.position;
    }
}
