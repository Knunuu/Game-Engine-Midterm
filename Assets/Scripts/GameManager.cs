using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance  { get; private set; }

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

    private void Update()
    {
        if (PlayerInstance1.Instance.GetHeight() >= 4.5f && PlayerInstance2.Instance.GetHeight() >= 4.5f)
        {
            WinStage();
        }
    }

    private void WinStage()
    {
        Debug.Log("YOU WIN");
    }
}
