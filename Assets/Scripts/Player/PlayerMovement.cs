using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector2 moveDirection;
    
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;

    [SerializeField] private KeyCode jumpKey = KeyCode.W;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(leftKey))
        {
            moveDirection = new Vector2(-1f, 0f);
            transform.rotation = Quaternion.LookRotation(moveDirection);
        }
        else if (Input.GetKey(rightKey))
        {
            moveDirection = new Vector2 (1f, 0f);
            transform.rotation = Quaternion.LookRotation(moveDirection);
        }
        else
        {
            moveDirection = Vector2.zero;
        }
        
        if(Input.GetKeyDown(jumpKey))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDirection * moveSpeed, ForceMode.Force);
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
    }

    public void ChangeKey(KeyCode jump, KeyCode left, KeyCode right)
    {
        jumpKey = jump;
        leftKey = left;
        rightKey = right;
    }
}
