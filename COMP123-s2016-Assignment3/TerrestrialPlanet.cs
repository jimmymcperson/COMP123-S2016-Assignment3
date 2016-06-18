using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_s2016_Assignment3
{

    /** <summary>
     * This class defines a "Terrestrial" variant of the Planet class.
     * </summary>
     * 
     * @class TerrestrialPlanet
     * @extends Planet
     */
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {

        // PRIVATE INSTANCE VARIABLES =================================================================================================

        private bool _oxygen;

        // PUBLIC PROPERTIES =================================================================================================

        // CONSTRUCTORS =================================================================================================

        /** <summary>
        * This constructor takes a boolean oxygen and assigns it to the _oxygen variable.
        * It also uses takes a string, name; a double, diameter; and a double, mass; for the default constructor for the Planet class.
        * </summary>
        *
        * @constructor TerrestrialPlanet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
        * @param {bool} oxygen
        */
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // PRIVATE METHODS =================================================================================================

        // PUBLIC METHODS =================================================================================================

        /** <summary>
         * This method returns a True boolean if the _oxygen field is True.
         * </summary>
         *
         * @method Habitable
         * @returns {bool}
         */
        public bool Habitable()
        {
            if (this._oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /** <summary>
         * This method returns a True boolean if the MoonCount property is True.
         * </summary>
         *
         * @method HasMoons
         * @returns {bool}
         */
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}