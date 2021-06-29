using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDisposableAnimation : StageAnimation
{
    private bool wasUsed = false;
    protected override void OnMouseDown()
    {
        if (!wasUsed & (blockStage == null || blockStage.isCompleted))
        {
            base.OnMouseDown();
            wasUsed = true;
        }
        else if (!blockStage.isCompleted)
        {
            view.AddError(this);
        }
    }
}
