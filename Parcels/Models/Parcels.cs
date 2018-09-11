using System;
using System.Collections.Generic;

namespace Parcels.Models
{
    public class Parcel
    {
        private int _height;
        private int _length;
        private int _width;
        private int _weight;
        private int _volume;

        public Parcel (string ht, string lth, string wth, string wt)
        {
            _height = int.Parse(ht);
            _length = int.Parse(lth);
            _width = int.Parse(wth);
            _weight = int.Parse(wt);
        }

        public int GetHeight()
        {
            return _height;
        }

        public int GetLength()
        {
            return _length;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public int Volume()
        {
            _volume = _height * _length * _width;
            return _volume;
        }


        public int GetPrice()
        {
            return _volume / 5000 + _weight / 50;
        }
    }
}
