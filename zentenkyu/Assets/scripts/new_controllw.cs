using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_controllw : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Rot = 0f;
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -2.5f, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 2.5f, 0));
        }
        
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Rot >= -90)
            {
                transform.Rotate(new Vector3(-2.5f, 0, 0));
                Rot = Rot - 2.5f;
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(2.5f, 0, 0));
        }
    }
}
