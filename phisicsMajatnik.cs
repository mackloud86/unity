using UnityEngine;

public class PendulumStarter : MonoBehaviour
{
    public float pushForce = 5f;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * pushForce, ForceMode.Impulse);
    }
}