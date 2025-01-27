﻿using SP.Models.Rolle;

namespace SP.Models
{
    public class StudentUnterricht
    {
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int LessonId { get; set; }
        public Unterricht Unterricht { get; set; } = null!;

        public DateTime ScheduledAt { get; set; }
    }
}
