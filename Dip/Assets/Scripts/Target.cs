using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    [SerializeField] private Trigger2D trigger2D;

    private void Awake()
    {
        trigger2D.onTriggerEnter2D += Trigger2D_OnTriggerEnter2D;
    }

    private void Trigger2D_OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
        }
    }
}