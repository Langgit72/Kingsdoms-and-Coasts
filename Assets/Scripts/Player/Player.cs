using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool interact;

    public Player instance;

    void Awake()
    {
        #region Singleton //Singleton instance
        if (instance == null)
        {
            instance = this; //if there is no current player instance in game, occupy singleton with current player class
        }
        else
        {
            Debug.LogWarning("More than one instance"); // otherwise there is already a player instance in game, and no more can be created
            Destroy(gameObject);
            return;
        }
        #endregion
    }
    private void Update()
    {
        interact = false;
    }

    void OnInteract()
    {
        interact = true;
        if (DialougeManager.instance.isRunning&&DialougeManager.instance.nextButton.isActiveAndEnabled) {
            DialougeManager.instance.DisplayNextSentence();
        }
    }
}
