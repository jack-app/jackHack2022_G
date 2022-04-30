using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
  public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,player.transform.position,0.02f);
    }

	// Cube.cs
	// 衝突の瞬間判定
	void OnCollisionEnter(Collision other)
	{
	  //SceneManager.LoadScene ("GameOver");
	}

	// 衝突離脱の判定
	void OnCollisionExit(Collision other)
	{
		Debug.Log (other.gameObject.name + "Exit");
	}
}
