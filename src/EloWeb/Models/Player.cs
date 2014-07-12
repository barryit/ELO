﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace EloWeb.Models
{
    public class Player
    {
        private LinkedList<int> _ratings = new LinkedList<int>();

        public string Name { get; set; }

        public int Rating
        {
            get
            {
                if(!_ratings.Any()) 
                    return 0;

                return _ratings.First.Value;
            }
        }

        public int MaxRating
        {
            get
            {
                if (!_ratings.Any())
                    return 0;
                
                return _ratings.Max();
            }
        }

        public int MinRating
        {
            get
            {
                if (!_ratings.Any())
                    return 0;

                return _ratings.Min();
            }
        }

        public void AddRating(int rating)
        {
            _ratings.AddFirst(rating);
        }

        public void ChangeRating(int points)
        {
            _ratings.AddFirst(Rating + points);
        }

        public void DecreaseRating(int points)
        {
            _ratings.AddFirst(Rating - points);
        }

        public static Player CreateInitial(string name)
        {
            var player = new Player {Name = name};
            player.AddRating(1000);
            return player;
        }
    }
}