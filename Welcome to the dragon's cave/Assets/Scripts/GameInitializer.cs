using System;
using System.Collections;
using System.Collections.Generic;
using Caches;
using Card.CardFactory;
using Character;
using Consts;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
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
    }

}
