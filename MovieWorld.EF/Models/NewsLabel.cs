// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MovieWorld.EF.Models
{
    public partial class NewsLabel
    {
        public Guid IdNews { get; set; }
        public Guid Idmultilingual { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }

        public virtual News IdNewsNavigation { get; set; }
        public virtual Multilingual IdmultilingualNavigation { get; set; }
    }
}