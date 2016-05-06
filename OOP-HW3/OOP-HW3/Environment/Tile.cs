﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public class Tile
    {
        //Our "image" for the tile. Represented by an int for now
        private int Image;

        public char Content { get; set; }

        //Flag for whether or not moving objects can pass through it
        private bool Passable { get; set; }

        public Tile(int image, bool passable)
        {
            Image = image;
            Passable = passable;
            Content = ' ';
        }
    }
}