﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleDecorator : IRifle
{
    protected IRifle m_DecoratedRifle;

    public RifleDecorator(IRifle rifle)
    {
        m_DecoratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return m_DecoratedRifle.GetAccuracy();
    }
}
