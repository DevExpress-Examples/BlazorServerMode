using System.Collections.Generic;

namespace InstantFeedback.Models {
    public class User {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
        public virtual ICollection<Issue> Issues { get; set; }
    }
}
