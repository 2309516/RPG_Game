using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerAttackNS;
public class Cleave : MonoBehaviour
{
    public PlayerAttackNS.PlayerAttack player;

    private void OnMouseDown()
    {
        player.CleaveCard();
    }
}
