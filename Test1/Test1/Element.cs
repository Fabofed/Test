﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    public class Element //avant s etait marqué public static mais 
        //j ai enlevé parce que je ne peux pas appeler 
        //une classe statique dans une autre classe(Olivier)
    {
        const double majorOppositionBonus = 2;
        const double minorOppositionBonus = 1.5;
        const double majorResistanceBonus = 0.5;
        const double minorResistanceBonus = 0.75;
        const double neutral = 1;

        public enum Elements
        {
            Fire, Magma, Earth, Vegetation, Water, Ice, Air, Electricity
        }
    }
}

