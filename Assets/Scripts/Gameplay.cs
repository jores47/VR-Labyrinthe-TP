using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;
public class Gameplay : MonoBehaviour
{
    public Text help;
    public AudioClip collectSnd;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       

        if (other.CompareTag("Indice"))
        {
            
                GetComponent<AudioSource>().PlayOneShot(collectSnd);
                other.gameObject.SetActive(false);
        }
    }
    
}

    
