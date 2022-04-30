using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    AudioSource m_MyAudioSource;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();    
        m_MyAudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
