using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Win : MonoBehaviour
{
    public TextMeshProUGUI winText;
    
    private void Start()
    {
        winText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        winText.gameObject.SetActive(true);
    }
}
