using System;

namespace Cafel.WebApi.Domain
{
    public class Content
    {
        public virtual Guid Id { get; set; }
        public virtual string Text { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual int LikeCount {get; set; }
    }
}