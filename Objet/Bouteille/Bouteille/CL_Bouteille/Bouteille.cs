using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Bouteille
{
    public class Bouteille
    {
        private bool alcool;
        private readonly float contenanceEnL;
        private float contenuEnL;
        private bool estGazeux;
        private readonly string matiere;
        private string nomBoisson;
        private bool estOuverte;

        public Bouteille() 
        { // Constructeur par défaut

            alcool = true;
            contenanceEnL = 0.75f;
            contenuEnL = 0;
            estGazeux = false;
            matiere = "verre";
            nomBoisson = "Bourgogne";
            estOuverte = true;

        }

        public Bouteille(bool _alcool, float _contenanceEnL, float _contenuEnL, bool _estGazeux, string _matiere, string _nomBoisson, bool _estOuverte)
        { // Constructeur classique

            this.alcool = _alcool;
            this.contenanceEnL = _contenanceEnL;
            this.contenuEnL = _contenuEnL;
            this.estGazeux = _estGazeux;
            this.matiere = _matiere;
            this.nomBoisson = _nomBoisson;
            this.estOuverte = _estOuverte;

        }

        public Bouteille(Bouteille bouteilleACopier)
        {// Constructeur par copie/clonage

            this.alcool = bouteilleACopier.alcool;
            this.contenanceEnL = bouteilleACopier.contenanceEnL;
            this.contenuEnL = bouteilleACopier.contenuEnL;
            this.estGazeux = bouteilleACopier.estGazeux;
            this.matiere = bouteilleACopier.matiere;
            this.nomBoisson = bouteilleACopier.nomBoisson;
            this.estOuverte = bouteilleACopier.estOuverte;

            // this = cet objet

        }

        public bool Ouvrir()
        {

            if (!this.estOuverte)
            {

                this.estOuverte = true;

                return true;

            }
            else
            {

                return false;

            }

        }

        public bool Fermer()
        {

            if (this.estOuverte)
            {
                this.estOuverte = false;

                return true;

            }
            else
            {

                return false;

            }

        }

        public bool Remplir()
        {

            if (this.contenuEnL < this.contenanceEnL && this.estOuverte)
            {

                this.contenuEnL = this.contenanceEnL;

                return true;

            }
            else
            {

                return false;

            }

        }

        public bool Vider()
        {

            if (this.contenuEnL > 0 && this.contenuEnL <= this.contenanceEnL && this.estOuverte)
            {

                this.contenuEnL = 0;

                return true;

            }
            else
            {

                return false;

            }

        }

        public bool Remplir(float quantiteARemplirEnL)
        {

            if (this.contenuEnL < this.contenanceEnL && this.estOuverte)
            {
                float nouveauContenu = this.contenuEnL + quantiteARemplirEnL;

                if (nouveauContenu <= this.contenanceEnL)
                {

                    this.contenuEnL += quantiteARemplirEnL;

                    return true;

                }
                else
                {

                    return false;

                }

            }
            else
            {

                return false;

            }

        }

        public bool Vider(float quantiteAViderEnL)
        {

            if (this.contenuEnL > 0 && this.estOuverte)
            {

                float nouveauContenu = this.contenuEnL - quantiteAViderEnL;

                if (nouveauContenu >= 0)
                {

                    this.contenuEnL -= quantiteAViderEnL;

                    return true;

                }
                else
                {

                    return false;

                }

            }
            else
            {

                return false;

            }

        }

    }
   

}