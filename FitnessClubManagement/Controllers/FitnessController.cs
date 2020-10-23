using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessClubManagement.BusinessLayer.Interfaces;
using FitnessClubManagement.BusinessLayer.ViewModels;
using FitnessClubManagement.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FitnessClubManagement.Controllers
{
    public class FitnessController : Controller
    {
        /// <summary>
        /// Creating referance variable of IFitnessClubServices and injecting in Controller Constructor
        /// </summary>
        private readonly IFitnessClubServices _fCServices;

        public FitnessController(IFitnessClubServices fitnessClubServices)
        {
            _fCServices = fitnessClubServices;
        }
        /// <summary>
        /// Show all Workout Plan on Index page of Fitness Controller, user can find and navigate workout by page also
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index(string search, int page = 1)
        {
            if (search != null)
            {
                var intView = new WorkoutViewModel
                {
                    WorkoutPerPage = 2,
                    Workouts = await _fCServices.FindWorkout(search),
                    CurrentPage = page
                };
                return View(intView);
            }
            else
            {
                var intView = new WorkoutViewModel
                {
                    WorkoutPerPage = 2,
                    Workouts = await _fCServices.AllWorkout(),
                    CurrentPage = page
                };
                return View(intView);
            }
        }
        /// <summary>
        /// Get  full details of Workout by WorkoutId
        /// </summary>
        /// <param name="workoutId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Details(int workoutId)
        {
            var place = await _fCServices.GetWorkoutById(workoutId);
            return View(place);
        }
        /// <summary>
        /// Show all Diet Plan for Vistor and GYMER
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> DietPlan()
        {
            IEnumerable<DietPlan> diet = await _fCServices.AllDietPlan();
            return View(diet);
        }
        /// <summary>
        /// Get full details of Diet Plan.
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> DietPlanDetails(int dietplanId)
        {
            var diet = await _fCServices.GetDietPlanById(dietplanId);
            return View(diet);
        }
        /// <summary>
        /// Book a appointment with GYM Trainer
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Bookappointment()
        {
            return View();
        }
        /// <summary>
        /// Book a appointment with GYM Trainer post method
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Bookappointment(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                Appointment newappointment = new Appointment
                {
                    FullName = appointment.FullName,
                    CurrentWeight = appointment.CurrentWeight,
                    Height = appointment.Height,
                    Age = appointment.Age,
                    GoalWeight = appointment.GoalWeight,
                    Address = appointment.Address,
                    PhoneNumber = appointment.PhoneNumber,
                    Email = appointment.Email,
                    Remark = appointment.Remark
                };
                var result = await _fCServices.BookAppointment(newappointment);
                return RedirectToAction("AppointInfo", "Fitness", new { appointmentId = result.AppointmentId });
            }
            return View();
        }
        /// <summary>
        /// Get appointment ifo for user
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AppointInfo(int appointmentId)
        {
            var appoint = await _fCServices.AppointmentInformation(appointmentId);
            return View(appoint);
        }
        /// <summary>
        /// List of tools we use at gym for information
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Toolsanddescription()
        {
            IEnumerable<Tools> tools = await _fCServices.AllTools();
            return View(tools);
        }
        /// <summary>
        /// Know about GYM instructor
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> GymInstructor()
        {
            IEnumerable<Instructor> instructor = await _fCServices.AllInstructor();
            return View(instructor);
        }
    }
}
