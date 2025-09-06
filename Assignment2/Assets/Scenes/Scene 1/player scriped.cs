using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscriped : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        public float speed = 10.0f;

        void Update()
    {
        fload h = Input.GetAxis("Horizontal");
        fload v = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(h, 0.0f, v);
        transform.Translate(movement * speed * Time.deltaTime);
    }
        
    }
}
