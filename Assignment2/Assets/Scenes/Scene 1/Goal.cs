using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public GameObject WinUI;
    private void OnTriggerEnter2D(Collider2D other)
    { 
        Debug.Log("Player entered Goal trigger: " + other.name);

       if (other.CompareTag("Player"))
        
        {
           Debug.Log("You Win!");
            WinUI.SetActive(true);
        }
     }
 }
