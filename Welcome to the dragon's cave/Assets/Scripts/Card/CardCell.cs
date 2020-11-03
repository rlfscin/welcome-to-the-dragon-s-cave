using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardCell : MonoBehaviour
{
    [SerializeField] private Image Background;
    [SerializeField] private Image Special;
    [SerializeField] private Image Cover;
    [SerializeField] private Text Name;
    [SerializeField] private Text Description;
    
    public void Setup(CardAssetList cardAssetList)
    {
        Background.sprite = cardAssetList.Background;
        Special.sprite = cardAssetList.Special;
        Cover.sprite = cardAssetList.Cover;    
        Name.text = cardAssetList.Name;    
        Description.text = cardAssetList.Description;

        Special.enabled = cardAssetList.Special != null;
    }
}
