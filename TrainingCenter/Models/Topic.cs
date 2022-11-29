using System.Collections.Generic;

namespace TrainingCenter.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string TopicName { get; set; }

        //Navigation 
        public List<Course> Courses { get; set; }
    }
}
