﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame1.Models
{
    public enum AnimationName
    {
        UpWalk = 0,
        DownWalk = 1,
        LeftWalk = 2,
        RightWalk = 3
    }

    class Animation
    {
        public Texture2D Texture { get; }

        public Vector2 StartPosition;

        public int NumFrames { get; }

        public int CurrentFrame { get; set; }

        public int MilliSecPerFrame { get; set; } = 80;

        public int FrameWidth { get; set; }

        public int FrameHeight{ get; set; }

        public Rectangle SourceRect { get; set; }
        

        public Dictionary<AnimationName, Vector2> AnimationStartPositions { get; set; }


        public Animation( Texture2D texture, Vector2 startPosition, int numFrames, int frameWidth, int frameHeight )
        {
            Texture = texture;
            StartPosition = startPosition;
            NumFrames = numFrames;

            CurrentFrame = 1;
            FrameWidth = frameWidth;
            FrameHeight = frameHeight;

            SourceRect = new Rectangle(0,
                                       0,
                                       FrameWidth,
                                       FrameHeight);
        }

    }
}
