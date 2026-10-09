using UnityEngine;

public class PlayerInstance1 : MonoBehaviour
{
    public static PlayerInstance1 Instance { get; private set; }
    private bool isDead = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public float GetHeight()
    {
        float height = transform.position.y;
        return height;
    }

    public bool GetStatus()
    {
        return isDead;
    }
}
