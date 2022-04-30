using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;


public class enemy : MonoBehaviour
{
    public GameObject player;
        NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.acceleration=10;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.transform.position; 
    }

	// Cube.cs
	// 衝突の瞬間判定
	void OnCollisionEnter(Collision other)
	{
        if(other.gameObject==player) {
          SceneManager.LoadScene ("GameOver");
        }
	}
}
