using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageColor : Stage
{
    [SerializeField] private Color32 disabledColor, activeColor;
    private Renderer renderer;

    protected override void Init()
    {
        renderer = GetComponent<Renderer>();
        SetState(isCompleted);
        base.Init();
    }

    public override void SetState(bool isActive)
    {
        if (isActive)
            renderer.material.color = activeColor;
        else
            renderer.material.color = disabledColor;
    }
}