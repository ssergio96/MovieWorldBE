﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MovieWorld.EF.Models
{
    public partial class Film
    {
        public Film()
        {
            Buy = new HashSet<Buy>();
            FilmGenre = new HashSet<FilmGenre>();
            Order = new HashSet<Order>();
            Realize = new HashSet<Realize>();
        }

        public string Format { get; set; }
        public double Price { get; set; }
        public short Year { get; set; }
        public bool IsSalable { get; set; }
        public short Availability { get; set; }
        public bool Cult { get; set; }
        public string Bgimage { get; set; }
        public string LinkImg { get; set; }
        public Guid FilmId { get; set; }

        public virtual ICollection<Buy> Buy { get; set; }
        public virtual ICollection<FilmGenre> FilmGenre { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Realize> Realize { get; set; }
    }
}