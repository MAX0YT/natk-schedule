using CollegeSchedule.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeSchedule.DTO
{
    public class GroupDTO
    {
        public string GroupName { get; set; } = null!;
        public string Course { get; set; } = null!;
        public string Specialty { get; set; } = null!;
    }
}
