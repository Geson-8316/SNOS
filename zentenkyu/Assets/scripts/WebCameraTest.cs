using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCameraTest : MonoBehaviour
{


    WebCamTexture webCamTexture;

    void Start()
    {
        GameObject sphere = GameObject.Find("Sphere");
        WebCamControll sphereScript = sphere.GetComponent<WebCamControll>();

        webCamTexture = sphereScript.webcamTexture;
        GetComponent<Renderer>().material.mainTexture = webCamTexture;
        webCamTexture.Play();
    }

    void Update()
    {
    }
}
