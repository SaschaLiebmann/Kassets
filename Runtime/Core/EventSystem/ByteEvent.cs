﻿using UnityEngine;

namespace Kassets.EventSystem
{
    [CreateAssetMenu(fileName = "ByteEvent", menuName = MenuHelper.DefaultEventMenu + "ByteEvent")]
    public class ByteEvent : GameEvent<byte>
    {
    }
}