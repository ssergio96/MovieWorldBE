﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MovieWorld.EF.Models
{
    public partial class News
    {
        public News()
        {
            NewsLabel = new HashSet<NewsLabel>();
        }

        public Guid NewsId { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Image { get; set; }

        public virtual ICollection<NewsLabel> NewsLabel { get; set; }
    }
}