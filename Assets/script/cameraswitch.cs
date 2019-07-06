using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswitch : MonoBehaviour {

    [SerializeField]
    Camera upcamera;
    [SerializeField]
    Camera secondcamera;
    // Use this for initialization
    void Start () {
        upcamera.GetComponent<Camera>().enabled = true;
        secondcamera.GetComponent<Camera>().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("t"))
        {
            Debug.Log("textnfnlnfgnlffg");
            upcamera.GetComponent<Camera>().enabled = false;
            secondcamera.GetComponent<Camera>().enabled = true;
        }
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("textnfnlnfgnlffg");
            upcamera.GetComponent<Camera>().enabled = true;
            secondcamera.GetComponent<Camera>().enabled = false;
        }
    }
}
