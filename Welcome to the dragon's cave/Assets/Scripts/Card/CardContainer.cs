using System;
using System.Collections.Generic;
using UnityEngine;

public class CardContainer : MonoBehaviour
{
    [SerializeField] private CardConfigObject cardConfigObject;
    [SerializeField] private RectTransform cardList;
    [SerializeField] private GameObject CardPrefab;
    
    public void Setup(CharacterType charType)
    {
        List<CardAssetList> cardAssetLists = cardConfigObject.GetCardAssetList(charType);
        cardList.DetachChildren();
        foreach (var cardAssetList in cardAssetLists)
        {    
            CardCell cardCellObject = Instantiate(CardPrefab, cardList, false).GetComponent<CardCell>();
            cardCellObject.Setup(cardAssetList);
        }
        
    }
}
