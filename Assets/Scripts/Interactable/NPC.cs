using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable
{
    public int treeIndex;
    public DialougeTree tree;

    public override void Update()
    {
        if (playerClose)
        {
            if (m_player.interact && !DialougeManager.instance.isRunning)
            {
                DialougeManager.instance.StartDialouge(tree.dialougeList[treeIndex]);
            }
        }
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() != null)
        {
            m_player = collision.gameObject.GetComponent<Player>();
            playerClose = true;
            interactRenderer.enabled = true;
        }
    }
    public override void OnTriggerExit2D(Collider2D collision)
    {
        base.OnTriggerExit2D(collision);
        DialougeManager.instance.EndDialouge();
    }
}
