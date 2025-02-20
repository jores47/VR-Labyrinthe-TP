using UnityEngine;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Collections;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEditor.SearchService;

public class Victory : MonoBehaviour
{
    public Text leftTextUI;

    public float basechrono = 180;
    float chrono;
    public bool active = true;
    public GameObject gameOver;
    public Text Lp;
    public GameObject victory;
    public GameObject player;
    public GameObject playagain;

    public AudioClip explosion;
    bool isPaused = false;

    void Start()
    {
        chrono= basechrono;
    }
    void Update()
    {

        if (active)
        {

           
                if ((chrono >= 0))
                {
                     chrono -= Time.deltaTime;
                     leftTextUI.text = Mathf.Round(chrono).ToString() + " s";
                }
                else { 
                     active = false;
                    GetComponent<AudioSource>().PlayOneShot(explosion);
                    wait(1);
                    gameOver.gameObject.SetActive(true);
                    wait(3);
            }
            
            
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Final"))
        {
                
                    victory.gameObject.SetActive(true);
                    active = false;
        }
            
        
    }

    private void OnTriggerExit(Collider other)
    {

       
    }
    

    IEnumerator waitScene(int scene)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(scene);
    }
    IEnumerator wait(int min)
    {
        yield return new WaitForSeconds(min);
    }

}
