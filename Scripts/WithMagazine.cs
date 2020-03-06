using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithMagazine : RifleDecorator
{
    private float m_MagAccuracy = 7f;

    public WithMagazine(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_MagAccuracy;
    }
}
