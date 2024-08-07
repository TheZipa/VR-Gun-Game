﻿using FiringRange.Code.Data.StaticData;
using FiringRange.Code.Data.StaticData.Location;
using FiringRange.Code.Extensions;
using FiringRange.Code.Logic.Targets;
using UnityEngine;

namespace FiringRange.Code.Logic.Common.TargetPlace
{
    public class RandomTargetPlacement : TargetPlacement
    {
        private readonly RandomTargetConfig _targetConfig;

        public RandomTargetPlacement(Target[] targets, RandomTargetConfig targetConfig) : base(targets)
        {
            _targetConfig = targetConfig;
        }

        protected override void Replace(Target target) => 
            target.transform.position = GetRandomPositionInBounds();
        
        private Vector3 GetRandomPositionInBounds()
        {
            LocationBounds bounds = _targetConfig.LocationBounds;
            return new Vector3(bounds.XBounds.GetRandomInVector(),
                bounds.YBounds.GetRandomInVector(),
                bounds.ZBounds.GetRandomInVector());
        }
    }
}