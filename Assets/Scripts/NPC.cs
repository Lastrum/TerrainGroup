using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    public GameObject player;

    private NavMeshAgent npc;
        
    // Start is called before the first frame update
    void Start()
    {
        npc = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        npc.SetDestination(player.transform.position);
    }
}
