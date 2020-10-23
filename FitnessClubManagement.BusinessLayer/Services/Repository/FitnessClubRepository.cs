using FitnessClubManagement.DataLayer;
using FitnessClubManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubManagement.BusinessLayer.Services.Repository
{
    public class FitnessClubRepository : IFitnessClubRepository
    {
        /// <summary>
        /// Creating Referance variable of FitnessClubDbContext
        /// and injecting in FitnessClubRepository constructor for All CURD operation
        /// </summary>
        private readonly FitnessClubDbContext _fclubDbContext;
        
        public FitnessClubRepository(FitnessClubDbContext fitnessClubDbContext)
        {
            _fclubDbContext = fitnessClubDbContext;
        }
        /// <summary>
        /// Get all Diet Plan from InMemory DietPlan DbSet.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<DietPlan>> AllDietPlan()
        {
            var plan = await _fclubDbContext.DietPlans.
                OrderByDescending(x => x.DietplanId).ToListAsync();
            return plan;
        }
        /// <summary>
        /// Get all Diet Plan from InMemory Instructor DbSet.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Instructor>> AllInstructor()
        {
            var instructor = await _fclubDbContext.Instructors.
                OrderByDescending(x => x.InstructorId).ToListAsync();
            return instructor;
        }
        /// <summary>
        /// Get all Diet Plan from InMemory Tools DbSet.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Tools>> AllTools()
        {
            var tool = await _fclubDbContext.Tools.
                OrderByDescending(x => x.ToolsId).ToListAsync();
            return tool;
        }
        /// <summary>
        /// Get all Diet Plan from InMemory Workout DbSet.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> AllWorkout()
        {
            var workout = await _fclubDbContext.Workouts
                .OrderByDescending(x => x.WorkoutId).ToListAsync();
            return workout;
        }
        /// <summary>
        /// Get appointment Infromation 
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Appointment>> AppointmentInformation(int appointmentId)
        {
            var result = await _fclubDbContext.Appointments
                                 .Where(x => x.AppointmentId == appointmentId)
                                 .ToListAsync();
            return result;
        }

        /// <summary>
        /// Book a appointment at GYM for Demo Fitness inquery
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public async Task<Appointment> BookAppointment(Appointment appointment)
        {
            try
            {
                _fclubDbContext.Add(appointment);
                await _fclubDbContext.SaveChangesAsync();
                return appointment;
            }catch(Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Find a workout by Name and Main Goal
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> FindWorkout(string name)
        {
            var result = await _fclubDbContext.Workouts.
                Where(x => x.Name == name || x.MainGoal == name).Take(10).ToListAsync();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        public async Task<DietPlan> GetDietPlanById(int dietplanId)
        {
            var result = await _fclubDbContext.DietPlans
                                 .Where(x => x.DietplanId == dietplanId)
                                 .FirstOrDefaultAsync();
            return result;
        }

        /// <summary>
        /// Get workout Details by WorkoutId
        /// </summary>
        /// <param name="workoutId"></param>
        /// <returns></returns>
        public async Task<Workout> GetWorkoutById(int workoutId)
        {
            var result = await _fclubDbContext.Workouts
                                 .Where(x => x.WorkoutId == workoutId)
                                 .FirstOrDefaultAsync();
            return result;
        }
    }
}
