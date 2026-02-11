using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
    void Update()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}
