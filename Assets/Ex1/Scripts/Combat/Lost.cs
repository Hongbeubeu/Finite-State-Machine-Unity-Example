﻿using System.Collections;
using UnityEngine;

namespace Com.BeuStudio.TurnBasedGame.Combat
{
    public class Lost : State
    {
        public Lost(BattleSystem battleSystem) : base(battleSystem) { }

        public override IEnumerator Start()
        {
            BattleSystem.Interface.SetDialogText("You were defeated.");
            yield break;
        }
    }
}