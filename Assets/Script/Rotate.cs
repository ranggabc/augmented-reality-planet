using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotate : MonoBehaviour{
    public float rotationSpeed = 0.1f;

    // Start is called before the first frame update
    void Start() {
    }


    void OnMouseDrag() { // calls when mouse or touch is dragged
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.RotateAround(Vector3.down, XaxisRotation);
        transform.RotateAround(Vector3.right, YaxisRotation);
    }

}    