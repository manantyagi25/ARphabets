using UnityEngine;
using System.Collections;

public class SpinLogic : MonoBehaviour
{
    public GameObject Apple;

    float speed = 1f;

    /*void Update()
    {
        OnMouseDrag();
    }*/

    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * speed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * speed;
        // select the axis by which you want to rotate the GameObject
        //transform.Rotate(Vector3.down, XaxisRotation);
        Apple.transform.Rotate(Vector3.forward, -3*XaxisRotation);
        //Apple.transform.Rotate(Vector3.up, -3*YaxisRotation);
    }
}