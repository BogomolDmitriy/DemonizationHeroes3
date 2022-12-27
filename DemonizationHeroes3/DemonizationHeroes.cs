using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonizationHeroes3
{
    class DemonizationHeroes
    {
        private const int demonsHP = 35;
        private const int limitationDaemonie = 50;
        private int _amountPitLord; // количество пит лордов
        private int _creaturesHP; // HP существа
        private int _demonPowerHP; // сала демонения HP
        public int _creaturesSummoned { get; private set; } // призвано существ
        private int _neededHP; // Необходимо HP
        public int _necessaryCreatures { get; private set; } // необходимое количество существ
        private int _creaturesLostHP; //Потерянные HP
        private int _lostPitLordPuwer; // потеря мощности ПитЛорда
        public string message { get; private set; }


        private DemonizationHeroes(int AmountPitLord, int CreaturesHP)
        {
            _amountPitLord = AmountPitLord;
            _creaturesHP = CreaturesHP;
            _demonPowerHP = DemonPowerHP(_amountPitLord);
            _creaturesSummoned = CreaturesSummoned (_demonPowerHP);
            _neededHP = NeededHP(_creaturesSummoned);
            _necessaryCreatures = NecessaryCreatures();
            _creaturesLostHP = CreaturesLostHP(_necessaryCreatures, _demonPowerHP);
            _lostPitLordPuwer = LostPitLordPuwer(_amountPitLord, _creaturesSummoned);
            message = CreateText();
        }

        public static DemonizationHeroes Create (int AmountPitLord, int CreaturesHP)
        {
            if (AmountPitLord < 0 && CreaturesHP < 0)
            {
                throw new ArgumentOutOfRangeException("the input value must not be less than one");
            }

            return new DemonizationHeroes(AmountPitLord, CreaturesHP);
        }

        private int DemonPowerHP(int amountPitLord)
        {
            return limitationDaemonie * amountPitLord;
        }

        private int CreaturesSummoned(int neededHP)
        {
            return neededHP / demonsHP;
        }

        private int NeededHP ( int amountPitLord)
        {
            return amountPitLord * demonsHP;
        }

        private int NecessaryCreatures ()
        {
            double rezalt;
            if (_creaturesHP > demonsHP)
            {
                rezalt = _creaturesSummoned;
            }

            else
            {
                rezalt = (double)_neededHP / (double)_creaturesHP;
                if (rezalt % 1 != 0)
                {
                    rezalt++;
                }
            }

            return (int)rezalt;
        }

        private int CreaturesLostHP ( int necessaryCreatures, int neededHP)
        {
            return necessaryCreatures * _creaturesHP - neededHP;
        }

        private int LostPitLordPuwer (int amountPitLord, int creaturesSummoned)
        {
            return amountPitLord * limitationDaemonie - creaturesSummoned * demonsHP;
        }

        private string CreateText()
        {
            if (_creaturesLostHP == 0)
            {
                return "OK";
            }

            else if (_creaturesLostHP > 0 && _creaturesHP > demonsHP)
            {
                return $"Слишком много HP существ, потери = {_creaturesLostHP} hp";
            }

            else
            {
                return $"Потери HP существ соствляют {_creaturesLostHP*-1} hp ";
            }
        }

        //private int OptimalNumberOfPitlords ()
        //{
        //    int temporaryAmountPitLord = _amountPitLord;
        //    int temporaryNeededHP;
        //    int temporaryNecessaryCreatures = _neededHP / _creaturesHP;
        //    int temporaryLostHP = (int)_necessaryCreatures * _creaturesHP - _neededHP;
        //    do
        //    {
        //        temporaryAmountPitLord++;
        //        temporaryNeededHP = 
        //        temporaryNecessaryCreatures = 

        //    } while (true);
        //}
    }
}
