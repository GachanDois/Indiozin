using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerNavMesh : MonoBehaviour{

    [SerializeField] private Transform movePositionTranform;
    private NavMeshAgent navMeshAgent;

    private void Awake(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update(){
        navMeshAgent.destination = movePositionTranform.position;
    }
}
