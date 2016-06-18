using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_s2016_Assignment3
{

    /** <summary>
     * This class defines a "Giant" variant of the Planet class.
     * </summary>
     * 
     * @class GiantPlanet
     * @extends Planet
     */
    public class GiantPlanet : Planet
    {

        // PRIVATE INSTANCE VARIABLES =================================================================================================

        private string _type;

        // PUBLIC PROPERTIES =================================================================================================

        // CONSTRUCTORS =================================================================================================

        /** <summary>
        * This constructor takes either the string "Gas" or "Ice" and assigns it to the _type variable.
        * It also uses takes a string, name; a double, diameter; and a double, mass; for the default constructor for the Planet class.
        * </summary>
        *
        * @constructor GiantPlanet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
        * @param {string} type
        */
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }

        // PRIVATE METHODS =================================================================================================

        // PUBLIC METHODS =================================================================================================

        /** <summary>
         * This method returns a True boolean if the MoonCount property is greater than zero.
         * </summary>
         *
         * @method HasMoon
         * @returns {bool}
         */
        public bool HasMoons()
        {
            if (this.MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /** <summary>
         * This method returns a True boolean if the RingCount property is greater than zero.
         * </summary>
         *
         * @method HasRings
         * @returns {bool}
         */
        public bool HasRings()
        {
            if (this.RingCount > 0)
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