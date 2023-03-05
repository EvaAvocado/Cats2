using UnityEngine;

public class ChangePropAnimatorStatus : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string propKey;

    public void ChangeStatus(bool status)
    {
        animator.SetBool(propKey, status);
    }
}
