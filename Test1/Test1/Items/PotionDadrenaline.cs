﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;

namespace TravailSession.Items
{
    class PotionDadrenaline : Item
    {
        private Collection collection;
        private Item item;
        private Joueur joueur;
        private Monstre monstre;

        public PotionDadrenaline(string nom, string description, int Cout, Element type, List<Effet> effets) : base(nom, description, Cout, type, effets)
        {
        }

        public override void Utiliser(Joueur joueur, Monstre monstre)
        {
            // Inserer un traitement ici
            joueur.Inventaire.Supprimer(this.item, this.collection); //Enleve l'item de l'inventaire
        }
    }
}
