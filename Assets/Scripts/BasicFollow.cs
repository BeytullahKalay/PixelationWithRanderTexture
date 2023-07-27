using UnityEngine;

public class BasicFollow : MonoBehaviour
{
    [SerializeField] private Transform followObject;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float lerp;

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, followObject.position + offset, lerp * Time.fixedDeltaTime);
    }
}