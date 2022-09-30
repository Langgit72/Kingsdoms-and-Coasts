using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool playerClose;

    public Player m_player;

    public SpriteRenderer interactRenderer;

    public virtual void Start()
    {
        interactRenderer.enabled = false;
    }
    public virtual void Update()
    {
        if (playerClose)
        {
            if (m_player.interact) {
                Debug.Log("Fixed");
            }
        }
    }

    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() != null) {
            m_player = collision.gameObject.GetComponent<Player>();
            playerClose = true;
            interactRenderer.enabled = true;
        }
    }
    public virtual void OnTriggerExit2D(Collider2D collision)
    {
        m_player = null;
        playerClose = false;
        interactRenderer.enabled = false;
    }
}
