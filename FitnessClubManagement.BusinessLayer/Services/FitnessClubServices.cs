using FitnessClubManagement.BusinessLayer.Interfaces;
using FitnessClubManagement.BusinessLayer.Services.Repository;
using FitnessClubManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubManagement.BusinessLayer.Services
{
    public class FitnessClubServices : IFitnessClubServices
    {
        private readonly IFitnessClubRepository _fCRepository;

        /// <summary>
        /// Creating Referance of IFitnessClubRepository and injecting in FitnessClubServices constructor
        /// </summary>
        /// <returns></returns>
        public FitnessClubServices(IFitnessClubRepository fitnessClubRepository)
        {
            _fCRepository = fitnessClubRepository;
        }
        public async Task<IEnumerable<DietPlan>> AllDietPlan()
        {
            var diet = await _fCRepository.AllDietPlan();
            return diet;
        }
        /// <summary>
        /// Get all Instructor
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Instructor>> AllInstructor()
        {
            var instructor = await _fCRepository.AllInstructor();
            return instructor;
        }
        /// <summary>
        /// Get list of Tools 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Tools>> AllTools()
        {
            var tool = await _fCRepository.AllTools();
            return tool;
        }
        /// <summary>
        /// Get List of all workout
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> AllWorkout()
        {
            var workout = await _fCRepository.AllWorkout();
            return workout;
        }
        /// <summary>
        /// Get Appointment Information
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Appointment>> AppointmentInformation(int appointmentId)
        {
            var info = await _fCRepository.AppointmentInformation(appointmentId);
            return info;
        }

        /// <summary>
        /// Book Appointment for Demo 
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public async Task<Appointment> BookAppointment(Appointment appointment)
        {
            var appoint = await _fCRepository.BookAppointment(appointment);
            return appoint;
        }
        /// <summary>
        /// Find a workout from Workout Collection
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> FindWorkout(string name)
        {
            var workout = await _fCRepository.FindWorkout(name);
            return workout;
        }
        /// <summary>
        /// Get Diet Plan by Id
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        public async Task<DietPlan> GetDietPlanById(int dietplanId)
        {
            var dietPlan = await _fCRepository.GetDietPlanById(dietplanId);
            return dietPlan;
        }

        /// <summary>
        /// Get aworkout by Id
        /// </summary>
        /// <param name="workoutId"></param>
        /// <returns></returns>
        public async Task<Workout> GetWorkoutById(int workoutId)
        {
            var workout = await _fCRepository.GetWorkoutById(workoutId);
            return workout;
        }
    }
}
