using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageWithRotation : Stage
{
    public override void SetState(bool isActive)
    {
        if (isActive)
            transform.position += Vector3.up;
        else
            transform.position -= Vector3.up;
    }
}
