using System;

namespace Silverstoned
{
    public class CheeseDoodle
    {
        private readonly string _name;
        private readonly string _seed;
        public CheeseDoodle(string name, string seed)
        {
            _name = name;
            _seed = seed;
        }

        private string Cypher()
        {
            string cypherText = "";
            int characterCount = 0;
            foreach(char nameCharacter in _name)
            {   
                
                foreach(char seedCharacter in _seed)
                {
                    cypherText = cypherText + seedCharacter;
                }
                characterCount++;
            }
            return cypherText;
        }

        public string DeCypher(string name)
        {

        }
    }
}
