using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StartState : State
{


    public override void Run()
    {
        if (isFineshed)
            return;
    }
}
