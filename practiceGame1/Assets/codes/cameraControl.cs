using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public GameObject positionOfBall;

    Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - positionOfBall.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = positionOfBall.transform.position + distance;
    }
}
