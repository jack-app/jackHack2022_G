using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBahavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(0.0f, 0.1f, 0.1f);
      transform.Rotate(1.0f, 1.0f, 0.0f);
    }
}
