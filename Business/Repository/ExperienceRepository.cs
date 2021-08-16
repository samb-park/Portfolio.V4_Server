using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Business.Repository
{
    public class ExperienceRepository : IExperienceRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ExperienceRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ExperienceDTO> CreateExperience(ExperienceDTO experienceDTO)
        {
            Experience experience = _mapper.Map<ExperienceDTO, Experience>(experienceDTO);
            var addedExperience = await _db.Experiences.AddAsync(experience);
            await _db.SaveChangesAsync();

            return _mapper.Map<Experience, ExperienceDTO>(addedExperience.Entity);
        }

        public async Task<ExperienceDTO> UpdateExperience(int experienceId, ExperienceDTO experienceDTO)
        {
            try
            {
                if (experienceId == experienceDTO.Id)
                {
                    Experience experienceDetail = await _db.Experiences.FindAsync(experienceId);
                    Experience experience = _mapper.Map<ExperienceDTO, Experience>(experienceDTO,experienceDetail);
                    var updatedExperience = _db.Experiences.Update(experience);
                    await _db.SaveChangesAsync();
                    
                    return _mapper.Map<Experience, ExperienceDTO>(updatedExperience.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<ExperienceDTO> GetExperience(int experienceId)
        {
            try
            {
                ExperienceDTO experience = _mapper.Map<Experience,ExperienceDTO>(
                    await _db.Experiences.FirstOrDefaultAsync(x => x.Id == experienceId));

                return experience;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<ExperienceDTO>> GetAllExperiences()
        {
            try
            {
                IEnumerable<ExperienceDTO> experienceDTOs = 
                    _mapper.Map<IEnumerable<Experience>,IEnumerable<ExperienceDTO>>(_db.Experiences);
                
                return experienceDTOs;
            }
            catch (Exception )
            {
                return null;
            }
        }

        public async Task<ExperienceDTO> IsExperienceUnique(string title,int experienceId = 0)
        {
            try
            {
                ExperienceDTO experience = null;
                if (experienceId == 0)
                {
                    experience = _mapper.Map<Experience, ExperienceDTO>(
                        await _db.Experiences.FirstOrDefaultAsync(x=>x.Title.ToLower() == title.ToLower()));
                }
                else
                {
                    experience = _mapper.Map<Experience, ExperienceDTO>(
                        await _db.Experiences.FirstOrDefaultAsync(x=>x.Title.ToLower() == title.ToLower()
                        && x.Id != experienceId));
                }

                return experience;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<int> DeleteExperience(int experienceId)
        {
            var experienceDetail = await _db.Experiences.FindAsync(experienceId);
            if (experienceDetail != null)
            {
                _db.Experiences.Remove(experienceDetail);
                return await _db.SaveChangesAsync();
            }

            return 0;
        }
    }
}