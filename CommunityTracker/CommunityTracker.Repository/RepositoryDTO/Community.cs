using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityTracker.Repository.Entities
{
    [Table("community")]
    public class Community
    {
        [Key]
        [Column("communityid")]
        public int CommunityId { get; set; }
        [Column("communityname")]
        public string CommunityName { get; set; }
        [Column("communityicon")]
        public string? CommunityIcon { get; set; }
        [Column("communitymgrid")]
        public int? CommunityMgrid { get; set; }
        [Column("communitydesc")]
        public string? CommunityDesc { get; set; }
        [Column("isactive")]
        public bool IsActive { get; set; }
    }
}