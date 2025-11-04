using UnityEngine;

public class FacingCamera : MonoBehaviour
{
    void Update()
    {
        transform.LookAt(Camera.main.transform);
        transform.Rotate(0, 180f, 0);
    }
}
