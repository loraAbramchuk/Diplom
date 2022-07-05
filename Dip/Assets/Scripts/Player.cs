using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private int thrustForse;

  private SpringJoint2D currentSpringJoint;
  private Rigidbody2D _rigidbody2D;

  
    // Start is called before the first frame update
    void Start()
    {
         currentSpringJoint = GetComponent<SpringJoint2D>();
         _rigidbody2D = GetComponent<Rigidbody2D>();
         _rigidbody2D.AddForce(Vector2.left*thrustForse);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentSpringJoint.enabled = false;
        }

        if (transform.position.x > 2 || transform.position.x < -2 && transform.position.y < -5)
        {
            gameObject.SetActive(false);
            Debug.Log("Fall");
        }

      
    }

    private void FixedUpdate()
    {
        
    }

}
