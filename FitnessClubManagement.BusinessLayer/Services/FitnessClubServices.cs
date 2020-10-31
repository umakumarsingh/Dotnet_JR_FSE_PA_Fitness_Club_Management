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
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all Instructor
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Instructor>> AllInstructor()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get list of Tools 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Tools>> AllTools()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get List of all workout
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> AllWorkout()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Appointment Information
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Appointment>> AppointmentInformation(int appointmentId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Book Appointment for Demo 
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public async Task<Appointment> BookAppointment(Appointment appointment)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find a workout from Workout Collection
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> FindWorkout(string name)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Diet Plan by Id
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        public async Task<DietPlan> GetDietPlanById(int dietplanId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get aworkout by Id
        /// </summary>
        /// <param name="workoutId"></param>
        /// <returns></returns>
        public async Task<Workout> GetWorkoutById(int workoutId)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
