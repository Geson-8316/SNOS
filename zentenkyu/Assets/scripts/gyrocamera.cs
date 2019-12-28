using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyrocamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        Quaternion q = Input.gyro.attitude;
        Quaternion qq = Quaternion.AngleAxis(-90.0f, Vector3.left);
        q.x *= -1.0f;
        q.y *= -1.0f;
        transform.localRotation = qq * q;
    }
}
