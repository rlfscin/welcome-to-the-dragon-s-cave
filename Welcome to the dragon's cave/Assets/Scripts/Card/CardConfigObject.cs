using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct CardAssetList
{
    public string Name;
    public string Description;
    public Sprite Special;
    public Sprite Cover;
    public Sprite Background;
    public CardType CardType;
    public CharacterType CharacterType;
}
[Serializable]
public class CardConfigObject : ScriptableObject
{
    [SerializeField] private List<CardAssetList> cardAssetList;

    public List<CardAssetList> GetCardAssetList(CharacterType characterType)
    {
        return cardAssetList.FindAll((charAssetList) => charAssetList.CharacterType == characterType);
    }
}
