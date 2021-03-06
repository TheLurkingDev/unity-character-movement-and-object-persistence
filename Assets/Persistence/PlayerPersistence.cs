﻿using UnityEngine;

namespace TheLurkingDev.Persistence
{
    public class PlayerPersistence
    {
        public Vector3 PlayerPosition { get; set; }

        public PlayerPersistence(Vector3 currentPosition)
        {
            this.PlayerPosition = currentPosition;
        }
    }
}
