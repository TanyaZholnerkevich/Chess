using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SwordData", menuName = "Items/Sword", order = 0)]
public class SwordData : ScriptableObject
{
    [Header("Events")]
    [SerializeField] private GameEvent updateEvent;
    [Header("Data")]
    [SerializeField] private string swordName;
    [SerializeField] private string description;
    [SerializeField] private GameObject prefab;
    [SerializeField] private Sprite icon;
    [SerializeField] private int cost;
    [SerializeField] private int damage;
    [Range(0f, 180f)] 
    [SerializeField] private float rotationSpeed;

    public string SwordName => swordName;
    public string Description => description;
    public GameObject Prefab => prefab;
    public Sprite Icon => icon;
    public int Cost => cost;
    public int Damage => damage;
    public float RotationSpeed => rotationSpeed;

    [ContextMenu("Update Event")]
    public void UpdateEvent()
    {
        updateEvent.Raise();
    }
    
}
