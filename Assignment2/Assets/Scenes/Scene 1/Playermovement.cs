using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
        public float speed = 10.0f;

        void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(h, v);
        transform.Translate(movement * speed * Time.deltaTime);
    }
       
}