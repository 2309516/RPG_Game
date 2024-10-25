using UnityEngine;
using PlayerAttackNS;
using System.Numerics;
using Unity.VisualScripting;

public class Slash : MonoBehaviour
{
    public PlayerAttackNS.PlayerAttack player;

    private void OnMouseDown()
    {
        player.SlashCard();
    }  
}
