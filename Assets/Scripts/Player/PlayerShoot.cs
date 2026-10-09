using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform spawn;
    [SerializeField] private KeyCode shootKey = KeyCode.F;
    [SerializeField] private float shootSpeed = 2f;

    private void Update()
    {
        if(Input.GetKeyDown(shootKey))
        {
            Rigidbody rb = Instantiate(projectile, spawn.position, transform.rotation).GetComponent<Rigidbody>();

            rb.linearVelocity = new Vector2(spawn.rotation.x * shootSpeed, 0f);
        }
    }

    public void ChangeKey(KeyCode key)
    {
        shootKey = key;
    }
}
