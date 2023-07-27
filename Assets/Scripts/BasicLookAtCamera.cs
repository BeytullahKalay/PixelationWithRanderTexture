using UnityEngine;

public class BasicLookAtCamera : MonoBehaviour
{
    [SerializeField] private Camera cameraToLook;

    private void Update()
    {
        transform.LookAt(cameraToLook.transform.position);
    }
}
