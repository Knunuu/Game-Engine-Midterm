using UnityEngine;

public class PlayerFactory : MonoBehaviour
{
    [SerializeField] private Material playerMat;
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private KeyCode jumpKey = KeyCode.W;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;
    [SerializeField] private KeyCode shootKey = KeyCode.F;
    
    public virtual void CreatePlayer()
    {
        GameObject player = Instantiate(playerPrefab, transform.position, transform.rotation);
        player.GetComponent<Renderer>().material = playerMat;
        player.GetComponent<PlayerMovement>().ChangeKey(jumpKey, leftKey, rightKey);
        player.GetComponent<PlayerShoot>().ChangeKey(shootKey);
    }
}
