﻿using System;
using UnityEngine;

namespace Kadinche.Kassets.UnityComponents
{
    public class OnDestroyCallbackComponent : MonoBehaviour
    {
        public Action OnDestroyAction { get; set; }
        private void OnDestroy() => OnDestroyAction?.Invoke();
    }
}