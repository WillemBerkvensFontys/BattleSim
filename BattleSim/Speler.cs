using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BattleSim
{
    class Speler
    {
        private string naam;
        private int hitPoints = 100;
        
        private static Random randomDamage = null;

        public Speler(string Naam, int HitPoints)
        {
            naam = Naam;
            hitPoints = HitPoints;
            randomDamage = new Random();
        }

        public Speler(int HitPoints)
        {
            hitPoints = HitPoints;
            randomDamage = new Random();
        }

        public int GetHitPoints()
        {
            return hitPoints;
        }

        public string GetName()
        {
            return naam;
        }

        public void DealDamageKnight(int hitpoints)
        {
            int damageRandomCalc = randomDamage.Next(0, 30);
            if (damageRandomCalc == 0)
            {
                MessageBox.Show("Je aanval Mist!");
            }
            else if (damageRandomCalc >= 25)
            {
                MessageBox.Show("Critical Hit!");
            }
            hitPoints = hitPoints - damageRandomCalc;    
        }

        public void DealDamageMage()
        {
            int damageRandomCalc = randomDamage.Next(15, 30);
            if (damageRandomCalc == 15)
            {
                MessageBox.Show("Je aanval Mist!");
                damageRandomCalc = 0;
            }
            else if (damageRandomCalc >= 25)
            {
                MessageBox.Show("Critical Hit!");
            }
            hitPoints = hitPoints - damageRandomCalc;
        }

        public void DealDamageSpearman()
        {
            int damageRandomCalc = randomDamage.Next(0, 22);
            if (damageRandomCalc == 0)
            {
                MessageBox.Show("Je aanval Mist!");
            }
            else if (damageRandomCalc >= 18)
            {
                MessageBox.Show("Critical Hit!");
            }
            hitPoints = hitPoints - damageRandomCalc;
        }
    }
}
