﻿using UnityEngine;

public abstract class Rule : ScriptableObject
{
    [TextArea]
    public string description;

    public abstract bool TestRuleValid(WFCItem self, WFCItem other);
}