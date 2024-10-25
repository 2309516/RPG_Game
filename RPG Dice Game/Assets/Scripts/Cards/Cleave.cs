using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerAttackNS;
public class Cleave : MonoBehaviour
{
    public PlayerAttackNS.PlayerAttack player;
    private UnityEngine.Vector3 startPosition;
    private UnityEngine.Vector3 targetPosition;
    private SpriteRenderer spriteRenderer;
    public Color changeColour = Color.gray;
    public float moveHeight = 1f;
    public float moveSpeed = 10f;
    private bool moving = false;

    void Start()
    {
        startPosition = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        targetPosition = new UnityEngine.Vector3(startPosition.x, startPosition.y + moveHeight, startPosition.z);
    }
    void Update()
    {
        if (moving)
        {
            transform.position = UnityEngine.Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = UnityEngine.Vector3.MoveTowards(transform.position, startPosition, moveSpeed * Time.deltaTime);
        }
    }
    void OnMouseDown()
    {
        player.CleaveCard();
    }
    void OnMouseEnter()
    {
        moving = true;
        spriteRenderer.color = changeColour;        
    }
    void OnMouseExit()
    {
        moving = false;
        spriteRenderer.color = Color.white;
    }   
}
