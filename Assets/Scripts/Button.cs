using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Button : MonoBehaviour
{
    public TextMeshProUGUI textHolder;
    private bool keybinds;

    private void Start()
    {
        keybinds = false;
    }


    private void Update()
    {
        if (keybinds)
        {
            if (Input.GetKeyDown("e"))
            {
                Debug.Log("GG");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            keybinds = true; 
            textHolder.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            keybinds = false; 
            textHolder.gameObject.SetActive(false);
        }
    }
}
