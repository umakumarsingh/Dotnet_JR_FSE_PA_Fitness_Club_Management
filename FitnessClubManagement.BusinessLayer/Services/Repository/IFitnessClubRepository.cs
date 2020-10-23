using FitnessClubManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubManagement.BusinessLayer.Services.Repository
{
    public interface IFitnessClubRepository
    {
        Task<IEnumerable<Workout>> AllWorkout();
        Task<IEnumerable<Workout>> FindWorkout(string name);
        Task<Workout> GetWorkoutById(int workoutId);
        Task<IEnumerable<DietPlan>> AllDietPlan();
        Task<DietPlan> GetDietPlanById(int dietplanId);
        Task<Appointment> BookAppointment(Appointment appointment);
        Task<IEnumerable<Instructor>> AllInstructor();
        Task<IEnumerable<Tools>> AllTools();
        Task<IEnumerable<Appointment>> AppointmentInformation(int appointmentId);
    }
}
