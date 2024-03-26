using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STORYGAME
{
 
    public class Enums
    {
        public enum StoryType
        {
            MAIN,
            SUB,
            SERIAL
        }
        
        public enum EvenType
        {
            NONE,
            GoToBattle = 100,
            CheckSTR = 1000,
            CheckDEX,
            CheckINK,
            CHECKWIS,
            CheckCHA
        }

        public enum ResultType
        {
            ChangeHp,
            ChangeSp,
            AddExperience,
            GoToShop,
            GoToNextStory,
            GoToRandeomStory,
            GoToEnding
        }

        
    }

    [System.Serializable]

    public class Stats
    {
        //ü�°� ���ŷ�
        public int hpPoint;
        public int spPoint;

        public int currentHpPoint;
        public int currentSpPoint;
        public int currentXpPoint;

        //�⺻ ���� ���� (D&D)
        public int strength;        //STR
        public int dexterity;       //DEX
        public int consitiution;    //CON
        public int Intelligence;    //INT
        public int wisdom;          //WIS
        public int Charisma;        //CHA
    }

}
