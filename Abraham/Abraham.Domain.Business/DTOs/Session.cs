using System;

namespace Abraham.Domain.Business.DTOs
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
        public int CmpId { get; set; }
    }
}
