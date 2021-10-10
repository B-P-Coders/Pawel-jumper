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
    private Vector3 Distance;
    [SerializeField]
    private Transform Placeholder;
    [SerializeField]
    private Transform Player;
    void Start()
    {
        transform = GetComponent<Transform>();
        startPosition = transform.position;
    }

    void Update()
    {
        this.transform.position = new Vector3(transform.position.x , Player.position.y , transform.position.z);
        if (startPosition.y + Distance.y < transform.position.y) generatePlatform();
    }

    private void generatePlatform()
    {
        int platformId = Random.Range(0, 2);
        int levelId = Random.Range(0, 2);
        Instantiate(Platforms[platformId], Levels[levelId].position, Quaternion.identity, Placeholder);
        startPosition = transform.position;
    }
}
