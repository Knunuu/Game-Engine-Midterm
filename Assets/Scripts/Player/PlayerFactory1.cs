using UnityEngine;

public class PlayerFactory1 : PlayerFactory
{
    [SerializeField] private PlayerInstance1 playerInstance1;
    public override void CreatePlayer()
    {
        base.CreatePlayer();
        // player.AddComponent(playerInstance1);
    }
}
