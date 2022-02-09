using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class Character : MonoBehaviour
    {
        [SerializeField] protected CharacterInfo characterInfo;
        [SerializeField] private Image healthSlider;

        protected float maxHp;

        private void OnEnable()
        {
            maxHp = characterInfo.Hp;
            OnHpChanged(maxHp);
            characterInfo.Hp.Variable.OnValueChanged += OnHpChanged;
        }

        private void OnDisable()
        {
            characterInfo.Hp.Variable.OnValueChanged -= OnHpChanged;
        }

        private void OnHpChanged(float hp)
        {
            healthSlider.fillAmount = hp / maxHp;
        }
    }
    
}