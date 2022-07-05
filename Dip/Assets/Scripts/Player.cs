using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private int thrustForse;

  private SpringJoint2D currentSpringJoint;

  
    // Start is called before the first frame update
    void Start()
    {
         currentSpringJoint = GetComponent<SpringJoint2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentSpringJoint.enabled = false;
        }

      
    }

    private void FixedUpdate()
    {
        //currentSpringJoint.reactionForce(thrustForse, 0);
    }
}
