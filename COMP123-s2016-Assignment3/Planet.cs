using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_s2016_Assignment3
{
    /** <summary>
     * This abstract class defines a planet.
     * </summary>
     * 
     * @class Planet
     */
    public abstract class Planet
    {

        // PRIVATE INSTANCE VARIABLES =================================================================================================

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES =================================================================================================

        /**<summary>
        * This property reads the _diameter field.
        * </summary>
        *
        * @property Diameter
        */
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        /**<summary>
        * This property reads the _mass field.
        * </summary>
        *
        * @property Mass
        */
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }


        /**<summary>
        * This property reads/writes the _moonCount field.
        * </summary>
        *
        * @property MoonCount
        */
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }

            set
            {
                this.MoonCount = value;
            }
        }

        /**<summary>
        * This property reads the _name field.
        * </summary>
        *
        * @property Name
        */
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        /**<summary>
        * This property reads/writes the _orbitalPeriod field.
        * </summary>
        *
        * @property OrbitalPeriod
        */
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }

            set
            {
                this._orbitalPeriod = value;
            }
        }

        /**<summary>
        * This property reads/writes the _ringCount field.
        * </summary>
        *
        * @property RingCount
        */
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }

            set
            {
                this._ringCount = value;
            }
        }

        /**<summary>
        * This property reads/writes the _rotationPeriod field.
        * </summary>
        *
        * @property RotationPeriod
        */
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }

            set
            {
                this._rotationPeriod = value;
            }
        }

        // CONSTRUCTORS =================================================================================================

        /** <summary>
        * This constructor takes name, diameter, and mass as parameters and assigns them to the appropriate fields.
        * </summary>
        *
        * @constructor Planet
        * @params {string} name
        * @params {double} diameter
        * @params {double} mass
        */
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;

        }

        // PRIVATE METHODS =================================================================================================

        // PUBLIC METHODS =================================================================================================

        /** <summary>
         * This method displays the _name, _diameter, and _mass fields.
         * </summary>
         *
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            return String.Format("*******************\nName: {0}\nDiameter: {1}\nMass: {2}\n*******************", this.Name, this.Diameter, this.Mass);
        }
    }
}