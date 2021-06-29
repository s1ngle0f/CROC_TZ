using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stage : MonoBehaviour
{
    [SerializeField] protected View view;
    [SerializeField] protected Stage blockStage;
    public bool isCompleted, isBackToStartState = true;
    public virtual void SetState(bool isActive) { }

    private void Awake()
    {
        Init();
    }

    protected virtual void Init()
    {
        //isCompleted = false;
    }

    protected virtual void OnMouseDown()
    {
        if ( blockStage == null || blockStage.isCompleted)
        {
            isCompleted = !isCompleted;
            SetState(isCompleted);
            view.SwitchStateObject(this);
        }
        else if(!blockStage.isCompleted)
        {
            view.AddError(this);
        }
    }
}
