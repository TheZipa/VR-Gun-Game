﻿using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace FiringRange.Code.Logic.Weapons
{
    public abstract class Weapon : MonoBehaviour
    {
        public WeaponShooter Shooter => _weaponShooter;
        public WeaponCasingReleaser Casing => _weaponCasing;
        public WeaponAnimator Animator => _weaponAnimator;
        
        [SerializeField] protected XRGrabInteractable _grabInteractable;
        [SerializeField] protected WeaponShooter _weaponShooter;
        [SerializeField] protected WeaponAnimator _weaponAnimator;
        [SerializeField] protected WeaponCasingReleaser _weaponCasing;

        public void Construct(XRInteractionManager interactionManager) =>
            _grabInteractable.interactionManager = interactionManager;
    }
}