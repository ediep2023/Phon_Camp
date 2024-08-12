using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float xInput, yInput;
    public int jumpForce;

    bool jump = false;

    public float bulletSpeed;
    bool shoot = false;

    public GameObject bullet;
    public Transform bulletPos;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //rb.velocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        //xInput = Input.GetAxis("Horizontal");
        //yInput = Input.GetAxis("Vertical");

        //if (Input.GetButtonDown("Jump"))
        //{
        //	jump = true;
        //}
        //
        if (Input.GetButtonDown("Fire1"))
        {
        	shoot = true;
        }

    }
    void FixedUpdate()
    {
        //rb.velocity = new Vector3(xInput * speed, rb.velocity.y, yInput * speed);
        //if (jump)
        //{
        //	Jump();
        //	jump = false;
        //}

        if (shoot)
        {
        	Shoot();
        	shoot = false;
        }
    }

    //void Jump()
    //{
    //	rb.AddForce(0, jumpForce, 0);
    //}

    void Shoot()
    {
    	GameObject bulletSpawn = Instantiate(bullet, bulletPos.position, bullet.transform.rotation);
    	bulletSpawn.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletSpeed);
    }

}


