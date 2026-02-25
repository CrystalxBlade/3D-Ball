using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] Vector3 rotateAxis;
    void Update()
    {
        transform.Rotate(rotateAxis);
    }
}
