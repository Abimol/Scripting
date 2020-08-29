using System;
using System.Collections.Generic;
using System.Text;

namespace taller {

    class Critters {
      
        string name;
        float baseAttack;
        int baseDefense;
        short baseSpeed;

        string[] affinitys = { "Fire", "Wind", "Water", "Earth", "Dark", "Light" };
        short affinityCritter;
        
        float affinityMutliplier = 0.5f;

        short moveSet;
        short hp;

        Random random = new Random();

        public Critters() {

            name = "Abimol";
            baseAttack = random.Next(1,21);
            baseDefense = random.Next(1, 21);           
            baseSpeed = 10;
            affinityCritter = 1;
            moveSet = 2;
            hp = 1000;
        }

        public void Skills() {

            string nameSkill; 
            string affinitySkill;
            short attackSkill;
            short supportSkill;
            short power = 2;

            float damageValue = (baseAttack + power) * affinityMutliplier;
            Console.WriteLine(damageValue);
        }

        public void Affinitys() {
            
            float[,] numberAfinnity = new float[6, 6];

            for (int i = 0; i < numberAfinnity.GetLength(0); i++) {

                for (int j = 0; j < numberAfinnity.GetLength(1); j++) {

                    if (i == affinityCritter && j == affinityCritter) affinityMutliplier = 0.5f;
                    else affinityMutliplier = 1f;

                    Console.Write("Hola...");
                }
                Console.WriteLine();
            }

            /*if(numberAfinnity[0,0] == affinityCritter)
            numberAfinnity[0, 0] = 0.5f;
            numberAfinnity[0, 1] = 2f;
            numberAfinnity[0, 2] = 1f;
            numberAfinnity[0, 3] = 1f;
            numberAfinnity[0, 4] = 1f;
            numberAfinnity[0, 5] = 1f;

            numberAfinnity[1, 0] = 2f;
            numberAfinnity[1, 1] = 0.5f;
            numberAfinnity[1, 2] = 1f;
            numberAfinnity[1, 3] = 1f;
            numberAfinnity[1, 4] = 1f;
            numberAfinnity[1, 5] = 1f;

            numberAfinnity[2, 0] = 1f;
            numberAfinnity[2, 1] = 1f;
            numberAfinnity[2, 2] = 0.5f;
            numberAfinnity[2, 3] = 0.5f;
            numberAfinnity[2, 4] = 0.5f;
            numberAfinnity[2, 5] = 0.5f;

            numberAfinnity[3, 0] = 0.5f;
            numberAfinnity[3, 1] = 0.5f;
            numberAfinnity[3, 2] = 0.5f;
            numberAfinnity[3, 3] = 0.5f;
            numberAfinnity[3, 4] = 0.5f;
            numberAfinnity[3, 5] = 0.5f;

            numberAfinnity[4, 0] = 0.5f;
            numberAfinnity[4, 1] = 0.5f;
            numberAfinnity[4, 2] = 0.5f;
            numberAfinnity[4, 3] = 0.5f;
            numberAfinnity[4, 4] = 0.5f;
            numberAfinnity[4, 5] = 0.5f;

            numberAfinnity[5, 0] = 0.5f;
            numberAfinnity[5, 1] = 0.5f;
            numberAfinnity[5, 2] = 0.5f;
            numberAfinnity[5, 3] = 0.5f;
            numberAfinnity[5, 4] = 0.5f;
            numberAfinnity[5, 5] = 0.5f;*/

        }
    }
}
