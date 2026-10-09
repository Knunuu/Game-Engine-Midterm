using UnityEngine;

public class Bubble : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] private float riseSpeed = 2f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.transform.parent = transform;
            rb.linearVelocity = new Vector3(0f, riseSpeed, 0f);
        }

        if (other.CompareTag("Default"))
        {
            Destroy(gameObject);
        }
    }
}
