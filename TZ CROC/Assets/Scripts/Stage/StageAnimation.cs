using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageAnimation : Stage
{
    [SerializeField] private string disabledAnimation, activeAnimation;
    private Animator animator;

    protected override void Init()
    {
        animator = GetComponent<Animator>();
        base.Init();
    }

    public override void SetState(bool isActive)
    {
        if (isActive)
            animator.Play(activeAnimation);
        else
            animator.Play(disabledAnimation);
    }
}
