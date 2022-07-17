using UnityEngine;

public class Player : MonoBehaviour
{
    [Space] [SerializeField] private Rigidbody2D body2D;
    [SerializeField] private SpringJoint2D springJoint2D;


    [Space] [SerializeField] private int force;


    private void Start()
    {
        body2D.AddForce(Vector2.left * force);
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            springJoint2D.enabled = false;
        }
    }
}