using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioplay : MonoBehaviour
{
    

    public AudioSource audioSource; // ����� �ҽ�
    // Start is called before the first frame update
    void Awake()
    {
        
        if (audioscript.bgmaudio)
        {
            audioSource.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(!audioscript.bgmaudio) {
            audioSource.Pause();
        }
        
    }
}
