using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class CharacterFactory
    {
        private Dictionary<char,Character> flyweights = new Dictionary<char, Character>();
        public Character GetCharacter(char key)
        {
            Character character = null;
            if (flyweights.ContainsKey(key))
            {
                character = flyweights[key];
                return character;
            }

            switch (key)
            {
                case 'a':
                    character = new CharacterA();
                    break;
                case 'b':
                    character = new CharacterB();
                    break;
                case 'z':
                    character = new CharacterZ();
                    break;
                default:
                    return null;
            }
            if(character!=null)
            flyweights.Add(key,character);

            return character;
        }
    }
}
