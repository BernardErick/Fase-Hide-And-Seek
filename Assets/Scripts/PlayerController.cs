using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocity;
    public Rigidbody2D rigidbody2D;
    public bool is_C_pressed;
    public bool can_walk;
    public bool invulnerable;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement_controller();
        action_player();
    }
    void movement_controller() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(can_walk)
            this.rigidbody2D.transform.Translate(new Vector2(horizontal, vertical) * velocity * Time.deltaTime);
    }
    void action_player() {
        this.is_C_pressed = Input.GetKeyDown(KeyCode.C);
    }
}
