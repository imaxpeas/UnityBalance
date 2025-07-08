using UnityEngine;

public class Door1 : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void OnCollisionEnter(Collision collision)
    {
        animator.SetTrigger("Pass1");
    }
}
