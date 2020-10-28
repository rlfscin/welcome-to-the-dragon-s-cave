using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [SerializeField] private CardContainer cardList;
    // Start is called before the first frame update
    void Start()
    {
        
        // Factory
        CardFactory cardFactory = new CardFactory();
        CharacterFactory characterFactory = new CharacterFactory(cardFactory);
        
        // Cache
        PlayerCache playerCache = new PlayerCache();
        CacheCollection cacheCollection = new CacheCollection(playerCache);

        playerCache.ActiveCharacter = characterFactory.GetCharacter(CharacterType.Warrior);

        cardList.Setup(playerCache.ActiveCharacter.Type);
    }

}
