using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkenerBehavior : MonoBehaviour
{
    public GameObject light;
    // Start is called before the first frame update
    Quaternion goal;
    float timeCount=0;
    float speed = 0.05f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       light.transform.rotation = Quaternion.Lerp(light.transform.rotation, goal, timeCount * speed);
       timeCount = (timeCount + Time.deltaTime)%1;
    }
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.name=="Player"){
            goal = Quaternion.Euler(-108, -223, 73);
            Debug.Log("enter");
        }
    }
    void OnTriggerExit(Collider collider){
        if(collider.gameObject.name=="Player"){
            Debug.Log("exit");
            goal = Quaternion.Euler(-280, 537, -127);
        }
    }
}
