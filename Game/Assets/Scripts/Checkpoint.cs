using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script controls the checkpoint functions
 */

public class Checkpoint : MonoBehaviour
{
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
        if (SaveManager.instance)
        {
            SaveManager.instance.checkPointSave(_player);
        }
    }
}
