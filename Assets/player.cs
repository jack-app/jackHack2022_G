using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    float speed;
    void Update()
    {
      speed = ((float)(Time.deltaTime))*40.0f;
      if(Input.GetKey(KeyCode.UpArrow)){
      transform.Translate(0,0,speed);
      }
      if(Input.GetKey(KeyCode.DownArrow)){
      transform.Translate(0,0,-speed);
      }
      if(Input.GetKey(KeyCode.RightArrow)){
        transform.Rotate(0,0.5f,0);
      }
      if(Input.GetKey(KeyCode.LeftArrow)){
        transform.Rotate(0,-0.5f,0);
      }
      if (transform.position.y < -15.0f){
        SceneManager.LoadScene ("GameOver");
      }
    }
}
