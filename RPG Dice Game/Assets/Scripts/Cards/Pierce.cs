using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerAttackNS;
public class Pierce : MonoBehaviour
{
    public PlayerAttackNS.PlayerAttack player;

    private void OnMouseDown()
    {
        player.PierceCard();
    }
}
