using UnityEngine;
// This complete script can be attached to a camera to make it
// continuously point at another object.

public class LookAt : MonoBehaviour
{
    public Transform target;

    private void Start()
    {
    }

    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(target);
    }
}