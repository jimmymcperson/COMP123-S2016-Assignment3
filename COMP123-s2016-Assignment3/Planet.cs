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

        public double Diameter
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public double Mass
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public int MoonCount
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int RingCount
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public double RotationPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        // CONSTRUCTORS =================================================================================================

        public Planet()
        {
            throw new System.NotImplementedException();
        }

        // PRIVATE METHODS =================================================================================================

        // PUBLIC METHODS =================================================================================================

        public string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}