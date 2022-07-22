using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service.ServicesDTO
{
    /// <summary>
    /// 
    /// </summary>
    public class CommunityMembersDTO
    {

        /// <summary>
        /// Gets or sets the people identifier.
        /// </summary>
        /// <value>
        /// The people identifier.
        /// </value>
        public int PeopleId { get; set; }
        /// <summary>
        /// Gets or sets the community identifier.
        /// </summary>
        /// <value>
        /// The community identifier.
        /// </value>
        public int CommunityId { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the name of the middle.
        /// </summary>
        /// <value>
        /// The name of the middle.
        /// </value>
        public string MiddleName { get; set; }
        /// <summary>
        /// Gets or sets the hired date.
        /// </summary>
        /// <value>
        /// The hired date.
        /// </value>
        public string HiredDate { get; set; }
        /// <summary>
        /// Gets or sets the job level identifier.
        /// </summary>
        /// <value>
        /// The job level identifier.
        /// </value>
        public int JobLevelId { get; set; }
        /// <summary>
        /// Gets or sets the work state identifier.
        /// </summary>
        /// <value>
        /// The work state identifier.
        /// </value>
        public int WorkStateId { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; } 
    }
}
