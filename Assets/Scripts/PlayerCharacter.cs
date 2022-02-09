using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerCharacter : Character

    {
        [SerializeField] private Transform enemyTransform;

        private void Update()
        {
            var dist = enemyTransform.position.x - transform.position.x;
            if (dist >= 1f || characterInfo.Speed < 0f)
            {
                transform.Translate(Time.deltaTime * characterInfo.Speed * transform.forward, Space.World);
            }
        }
    }
}