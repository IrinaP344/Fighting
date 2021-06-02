using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
	NavMeshAgent move;
	public GameObject player;
	Transform player_transform;
    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<NavMeshAgent>();
        player_transform = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        move.SetDestination(player_transform.position);
    }

    void OnCollisionEnter(Collision collision_object)
    {
    	print("столкновение есть");
    	if(collision_object.gameObject.tag =="enemy")
    	{
    		Destroy(collision_object.gameObject);
    	}
    }
}
