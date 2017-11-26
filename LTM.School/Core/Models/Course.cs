using LTM.School.Application.enumType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models
{
    /// <summary>
    /// 课程
    /// </summary>
    public class Course
    {
         //[DatabaseGenerated(DatabaseGeneratedOption.None)]//这里是指不需要数据库生成主键
        public int CourseId { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
