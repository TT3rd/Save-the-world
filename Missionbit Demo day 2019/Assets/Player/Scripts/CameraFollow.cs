using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothspeed = 0.125f;
    public Vector3 offset;

    public void FixedUpdate(){
        Vector3 desiredpos = target.position + offset;
        Vector3 smoothedpos = Vector3.Lerp(transform.position, desiredpos, smoothspeed);
        transform.position = smoothedpos;
        transform.LookAt(target);
    }
    
}
