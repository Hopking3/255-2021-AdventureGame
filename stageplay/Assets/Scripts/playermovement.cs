using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public Rigidbody2D pawn;
    private SpriteRenderer sprit;
    public static Vector2 mousePosition;
    public Rigidbody2D blocker;
    // Start is called before the first frame update
    void Start()
    {
        pawn = GetComponent<Rigidbody2D>();
        sprit = GetComponent<SpriteRenderer>();
        blocker = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        mouseClicker();
    }
    void movePlayer()
    {
        
        if (Input.GetKey("d"))
        {
            //get input
            float v = Input.GetAxis("Vertical");//W + S, UP + DOWN, CONTROLLER UP + CONTROLLER DOWN | value between -1 & 1
            float h = Input.GetAxis("Horizontal");//A + D, LEFT + RIGHT, CONTROLLER LEFT + CONTROLLER RIGHT | value between -1 & 1

            transform.position += transform.right * moveSpeed * Time.deltaTime * h;
            sprit.flipX = false;
        }
        else if (Input.GetKey("a"))
        {
            //get input
            float v = Input.GetAxis("Vertical");//W + S, UP + DOWN, CONTROLLER UP + CONTROLLER DOWN | value between -1 & 1
            float h = Input.GetAxis("Horizontal");//A + D, LEFT + RIGHT, CONTROLLER LEFT + CONTROLLER RIGHT | value between -1 & 1

            transform.position += transform.right * moveSpeed * Time.deltaTime * h;
            sprit.flipX = true;
        }
        else
        {

        }
    }
    void mouseClicker()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = new Ray(pawn.transform.position, Input.mousePosition);
            if (Physics.Raycast(ray))
            {
                print("mouseclicker");
            }
        }
    }
}
