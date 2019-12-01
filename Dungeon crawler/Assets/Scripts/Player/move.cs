using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class move : MonoBehaviour
{
    // Start is called before the first frame update

public float movementSpeed;
private Vector2 moveVelocity;
private Rigidbody2D rb;

    void Start(){
     rb=GetComponent<Rigidbody2D>();
 }
    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput= new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity =moveInput.normalized * movementSpeed;
    }
    void FixedUpdate(){
        rb.MovePosition(rb.position + moveVelocity* Time.fixedDeltaTime);
    }
}
