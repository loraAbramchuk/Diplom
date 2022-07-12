using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int thrustForse;

    private SpringJoint2D currentSpringJoint;
    private Rigidbody2D _rigidbody2D;

    void Start()
    {
        currentSpringJoint = GetComponent<SpringJoint2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(Vector2.left * thrustForse);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentSpringJoint.enabled = false;
        }

        if (transform.position.y < -50)
        {
            gameObject.SetActive(false);
            Debug.Log("Fall");
        }
    }
}