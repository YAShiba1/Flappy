using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PistolAnimation : MonoBehaviour
{
    private int _shotHash = Animator.StringToHash("Shot");

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetShot()
    {
        _animator.SetTrigger(_shotHash);
    }
}
