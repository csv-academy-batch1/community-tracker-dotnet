using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Repository.RepositoryDTO
{
    /// <summary>
    /// 
    /// </summary>
    public class CommunityMembers
    {
        /// <summary>
        /// Gets or sets the people identifier.
        /// </summary>
        /// <value>
        /// The people identifier.
        /// </value>
        [Key]
        
        [Column("peopleid")]
        public int PeopleId { get; set; }

        /// <summary>
        /// Gets or sets the community identifier.
        /// </summary>
        /// <value>
        /// The community identifier.
        /// </value>
        [Column("communityid")]
        public int CommunityId { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [Column("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [Column("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the name of the middle.
        /// </summary>
        /// <value>
        /// The name of the middle.
        /// </value>
        [Column("middlename")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the hired date.
        /// </summary>
        /// <value>
        /// The hired date.
        /// </value>
        [Column("hireddate")]
        public DateTime HiredDate { get; set; }

        /// <summary>
        /// Gets or sets the job level identifier.
        /// </summary>
        /// <value>
        /// The job level identifier.
        /// </value>
        [Column("joblevelid")]
        public int JobLevelId { get; set; }

        /// <summary>
        /// Gets or sets the work state identifier.
        /// </summary>
        /// <value>
        /// The work state identifier.
        /// </value>
        [Column("joblevelid")]
        public int WorkStateId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        [Column("isactive")]
        public bool IsActive { get; set; } = true;

    }
}
