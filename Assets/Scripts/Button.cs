using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Button : MonoBehaviour
{
    public TextMeshProUGUI textHolder;
    public GameObject platform;
    private bool keybinds;

    private void Start()
    {
        platform.SetActive(false);
        keybinds = false;
    }


    private void Update()
    {
        if (keybinds)
        {
            if (Input.GetKeyDown("e"))
            {
                platform.SetActive(true);
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
