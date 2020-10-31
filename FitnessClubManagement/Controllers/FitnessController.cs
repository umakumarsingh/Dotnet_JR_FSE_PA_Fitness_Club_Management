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
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get  full details of Workout by WorkoutId
        /// </summary>
        /// <param name="workoutId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Details(int workoutId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Show all Diet Plan for Vistor and GYMER 'Use IEnumerable<DietPlan>'
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> DietPlan()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get full details of Diet Plan.
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> DietPlanDetails(int dietplanId)
        {
            //Do code here
            throw new NotImplementedException();
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
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get appointment ifo for user
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AppointInfo(int appointmentId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// List of tools we use at gym for information
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Toolsanddescription()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Know about GYM instructor
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> GymInstructor()
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
