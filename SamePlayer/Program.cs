﻿using System;
using System.Collections.Generic;

namespace SamePlayer
{
    public enum PlayerType { Tank, Fighter, Slayer, Mage, Controller, Marksmen }

    public class Player
    {
        public PlayerType Type { get; set; }
        public string Name { get; set; }

        public override int GetHashCode() => HashCode.Combine(Type, Name);
        
        public override bool Equals(object obj) => obj is Player otherPlayer && Type == otherPlayer.Type && Name == otherPlayer.Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            HashSet<Player> setOfPlayers = new HashSet<Player>
            {
                new Player { Type = PlayerType.Tank, Name = "Ana" },
                new Player { Type = PlayerType.Slayer, Name = "Paulo" },
                new Player { Type = PlayerType.Tank, Name = "Ana" }
            };
            Console.WriteLine("Number of players in the set: " + setOfPlayers.Count);
            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.Type}");
            }
        }
    }
}