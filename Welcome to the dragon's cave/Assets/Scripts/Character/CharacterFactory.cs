using Card.CardFactory;
using Consts;

namespace Character
{
    public class CharacterFactory
    {
        private CardFactory _cardFactory;

        public CharacterFactory(CardFactory cardFactory)
        {
            _cardFactory = cardFactory;
        }

        public Character GetCharacter(CharacterType characterType)
        {
            return new Character(characterType);
        }
    }
}