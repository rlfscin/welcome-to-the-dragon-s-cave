using Consts;

namespace Character
{
    public class Character
    {
        private CharacterType _characterType;

        public CharacterType Type => _characterType;
        

        public Character(CharacterType characterType)
        {
            _characterType = characterType;
        }
        
    }
}