using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script controls the checkpoint functions
 */

public class Checkpoint : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
        try
        {
            SaveManager.instance.checkPointSave(player);
        }
        catch
        {
            Debug.Log("Save Manager is missing!");
        }
    }
}
