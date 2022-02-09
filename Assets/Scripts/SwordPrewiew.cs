using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class SwordPrewiew : MonoBehaviour
{
    [SerializeField] private Transform rootPoint;
    [SerializeField] private Text nameLabel;
    [SerializeField] private Text descriptionLabel;
    [SerializeField] private Image iconImage;
    [SerializeField] private Text costLabel;
    [SerializeField] private Text damageLabel;

    [SerializeField] private SwordData swordData;

    private GameObject swordObj;
    void Start()
    {
        SetupData();
    }

    public void SetupData()
    {
        if (swordObj != null)
        {
            Destroy(swordObj);
        }
        swordObj = Instantiate(swordData.Prefab, rootPoint);
        nameLabel.text = swordData.SwordName;
        descriptionLabel.text = swordData.Description;
        iconImage.sprite = swordData.Icon;
        costLabel.text = $"Cost: {swordData.Cost}";
        damageLabel.text = $"Damage: {swordData.Damage}";
    }
    void Update()
    {
        rootPoint.Rotate(Time.deltaTime * swordData.RotationSpeed * Vector3.up, Space.World);
    }
}
