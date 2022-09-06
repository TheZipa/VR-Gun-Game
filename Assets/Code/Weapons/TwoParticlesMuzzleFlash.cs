using UnityEngine;

namespace Code.Weapons
{
    public class TwoParticlesMuzzleFlash : WeaponMuzzleFlash
    {
        [SerializeField] private ParticleSystem _firstMuzzle;
        [SerializeField] private ParticleSystem _secondMuzzle;

        public override void Show()
        {
            _firstMuzzle.Play();
            _secondMuzzle.Play();
        }
    }
}