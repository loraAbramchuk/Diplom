using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Trigger2D : MonoBehaviour
{
    public event Action<Collider2D> onTriggerEnter2D;
    public event Action<Collider2D> onTriggerExit2D;

    private void OnTriggerEnter2D(Collider2D other)
    {
        onTriggerEnter2D?.Invoke(other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        onTriggerExit2D?.Invoke(other);
    }
}