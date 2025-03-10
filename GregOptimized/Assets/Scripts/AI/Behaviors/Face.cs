﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : Align
{
    // TODO: override Align's getTargetAngle to face the target instead of matching it's orientation
    public override float getTargetAngle()
    {
        // --- replace me ---
        //float targetAngle = 0f;
        // ------------------

        Vector3 direction = target.transform.position - character.transform.position;
        direction.y = 0;
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

        return targetAngle;
    }
}
