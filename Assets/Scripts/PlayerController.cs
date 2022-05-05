using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocity;
    public Rigidbody2D rigidbody2D;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement_controller();
    }
    void movement_controller() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        this.rigidbody2D.transform.Translate(new Vector2(horizontal,vertical) * velocity * Time.deltaTime);
        //this.transform.Translate(new Vector2(horizontal, vertical) * velocity * Time.deltaTime);
    }

}
