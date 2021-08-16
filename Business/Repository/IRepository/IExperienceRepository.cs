using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Business.Repository.IRepository
{
    public interface IExperienceRepository
    {
        public Task<ExperienceDTO> CreateExperience(ExperienceDTO experienceDTO);
        public Task<ExperienceDTO> UpdateExperience(int experienceId, ExperienceDTO experienceDTO);
        public Task<ExperienceDTO> GetExperience(int experienceId);
        public Task<IEnumerable<ExperienceDTO>> GetAllExperiences();
        public Task<ExperienceDTO> IsExperienceUnique(string title,int experienceId = 0);
        public Task<int> DeleteExperience(int experienceId);
    }
}