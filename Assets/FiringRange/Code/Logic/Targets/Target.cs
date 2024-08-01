﻿using UnityEngine;

namespace FiringRange.Code.Logic.Targets
{
    public abstract class Target : MonoBehaviour
    {
        [SerializeField] protected Hit.Hit _hitBehaviour;

        private void Start() => Enable();

        public abstract void Enable();

        public abstract void Disable();

        public virtual void TakeHit() => _hitBehaviour.TakeHit();
    }
}