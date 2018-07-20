using System;

namespace Cafel.WebApi.Domain
{
    public class Content
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int LikeCount {get; set; }
    }
}