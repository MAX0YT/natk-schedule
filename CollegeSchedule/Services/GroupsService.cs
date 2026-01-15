using CollegeSchedule.Data;
using CollegeSchedule.DTO;
using CollegeSchedule.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CollegeSchedule.Services
{
    public class GroupsService : IGroupsService
    {
        private readonly AppDbContext _db;
        public GroupsService(AppDbContext db)
        {
            _db = db;
        }

        public List<GroupDTO> GetGroups()
        {
            var groups = Groups();
            return BuildGroupsDTO(groups);
        }
        private List<StudentGroup> Groups()
        {
            var groups = _db.StudentGroups;
            return groups.ToList();
        }
        private static List<GroupDTO> BuildGroupsDTO(List<StudentGroup> groups)
        {
            return groups.Select(group => new GroupDTO
            {
                GroupName = group.GroupName,
                Course = group.Course.ToString(),
                Specialty = group.Specialty.Name
            }).ToList();
        }
    }
}
