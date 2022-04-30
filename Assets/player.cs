using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.W)){
      transform.position += new Vector3(-0.1f,0,0);
      }
      if(Input.GetKey(KeyCode.S)){
      transform.position += new Vector3(0.1f,0,0);
      }
      if(Input.GetKey(KeyCode.D)){
      transform.position += new Vector3(0,0,0.1f);
      }
      if(Input.GetKey(KeyCode.A)){
      transform.position += new Vector3(0, 0,-0.1f);
      }
    }

	void OnTriggerEnter(Collider other)
	{
		Debug.Log (other.name + "Enter");
	}

	// 重なり中の判定
	void OnTriggerStay(Collider other)
	{
			Debug.Log (other.name + "Stay");
	}

	// 重なり離脱の判定
	void OnTriggerExit(Collider other)
	{
		Debug.Log (other.name + "Exit");
	}
}
