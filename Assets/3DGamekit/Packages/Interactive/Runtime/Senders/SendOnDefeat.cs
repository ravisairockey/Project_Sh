using Gamekit3D.GameCommands;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendOnDefeat : SendGameCommand
{
    private void OnDestroy()
    {
        Send();
    }
}
