using System.Collections.Generic;
using Consts;

namespace Card.CardFactory
{
    public class CardFactory
    {
        private Dictionary<CharacterType, List<Card>> cardsPerChacracter;
        public CardFactory()
        {
            cardsPerChacracter = new Dictionary<CharacterType, List<Card>>();

            List<Card> warriorCards = new List<Card>();
            warriorCards.Add(new Card());
            warriorCards.Add(new Card());
            warriorCards.Add(new Card());
            warriorCards.Add(new Card());
            warriorCards.Add(new Card());
            warriorCards.Add(new Card());
            cardsPerChacracter.Add(CharacterType.Warrior, warriorCards);
        }
        public List<Card> GetAllCards(CharacterType characterType)
        {
            return cardsPerChacracter[characterType];
        }
    }
}