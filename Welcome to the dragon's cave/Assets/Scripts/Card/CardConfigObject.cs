using System;
using System.Collections.Generic;
using Consts;
using UnityEngine;

namespace Card
{
    [Serializable]
    public struct CardAssetList
    {
        public string Name;
        public string Description;
        public Sprite Special;
        public Sprite Cover;
        public Sprite Background;
        public CardType CardType;
    }
    [Serializable]
    public class CardConfigObject : ScriptableObject
    {
        [SerializeField] public List<CardAssetList> CardAssetList;
    }
}