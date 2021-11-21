﻿using Casbin.Effect;

namespace Casbin;

public ref struct EnforceSession
{
    internal string ExpressionString { get; set; }

    internal int PolicyIndex { get; set; }
    internal int PolicyCount { get; set; }

    internal PolicyEffect PolicyEffect { get; set; }
    internal PolicyEffect[] PolicyEffects { get; set; }

    internal bool Determined { get; private set; }
    internal bool EnforceResult { get; set; }

    internal bool ExpressionResult { get; set; }
    
    internal bool IsChainEffector { get; set; }

    internal int? Priority { get; set; }

    internal void DetermineResult(bool result)
    {
        Determined = true;
        EnforceResult = result;
    }
}
