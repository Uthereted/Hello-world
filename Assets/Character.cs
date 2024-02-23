using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayableCharacters
{
    public class Character 
    {
        private int kills;
        public string name;
        private int healthPoints = 1;

        public Character(string name)
        {
            this.name = name;
            
            Debug.Log("Hola, soy " + name);
        }
        ~Character()
        {
            Debug.Log(name + " is dead");
        }
        public int HealthPoints { get => healthPoints; set => healthPoints = value; }

    }
}
