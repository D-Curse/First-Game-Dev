using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    public Animator animator;
    private Vector2 Movement;

    private void Start() 
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate() 
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDelta = new Vector3(x,y,0);

        if(moveDelta.x > 0){
            transform.localScale = Vector3.one;
        }
        else if(moveDelta.x<0){
            transform.localScale = new Vector3(-1,1,1);
        }

        hit = Physics2D.BoxCast(transform.position, boxCollider.size,0, new Vector2(moveDelta.x,0), Mathf.Abs(moveDelta.x*Time.deltaTime), LayerMask.GetMask("Actor","Blocking"));

        if (hit.collider== null)
        {
            transform.Translate(moveDelta.x*Time.deltaTime,0,0);
        }

        hit = Physics2D.BoxCast(transform.position, boxCollider.size,0, new Vector2(0,moveDelta.y), Mathf.Abs(moveDelta.y*Time.deltaTime), LayerMask.GetMask("Actor","Blocking"));
        if (hit.collider== null)
        {
            transform.Translate(0,moveDelta.y*Time.deltaTime,0);
        }
    }

    private void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal",Movement.x);
        animator.SetFloat("Vertical",Movement.y);
        animator.SetFloat("Speed",Movement.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
            Debug.Log("Attacked");
        }

    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }

   /* private void Awake() 
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetaxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Escape))
    }*/
}
