
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f; //camera moving
    public Vector3 offset;

    void LateUpdate()
    {
        //Vector3 desiredPosition = target.position + offset;
       // Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothPosition);
        transform.position = target.position + offset;

        //transform.LookAt(target);
    }


}
