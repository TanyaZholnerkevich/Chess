using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class EnemyCharacter : Character
    {
        [SerializeField] private Transform player;
        [SerializeField] private FloatVariable playerHp;

        private void Update()
        {
            if (Mathf.Abs(player.position.x - transform.position.x) > 1f)
            {
                transform.Translate(Time.deltaTime * characterInfo.Speed * transform.forward, Space.World);
                return;
            }

            playerHp.Value -= Time.deltaTime;
        }
    }
}