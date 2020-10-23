using FitnessClubManagement.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessClubManagement.BusinessLayer.ViewModels
{
    public class WorkoutViewModel
    {
        public string Name { get; set; }
        [Display(Name = "Main Goal")]
        public string Descriprtion { get; set; }
        public string MainGoal { get; set; }
        [Display(Name = "Workout Type")]
        public string WorkoutType { get; set; }
        [Display(Name = "Training Level")]
        public string TrainingLevel { get; set; }
        [Display(Name = "Program Duration")]
        public string ProgramDuration { get; set; }
        [Display(Name = "Days Per Week")]
        public int DaysPerWeek { get; set; }
        [Display(Name = "Time PerWor kout")]
        public string TimePerWorkout { get; set; }
        [Display(Name = "Equipment Required")]
        public string EquipmentRequired { get; set; }
        [Display(Name = "Target Gender")]
        public string TargetGender { get; set; }
        [Display(Name = "Recommended Supplements")]
        public string RecommendedSupplements { get; set; }
        public string Author { get; set; }//Fitness Trainer
        [Display(Name = "Workout PDF")]
        public string WorkoutPDF { get; set; }

        public IEnumerable<Workout> Workouts { get; set; }
        public int WorkoutPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(Workouts.Count() / (double)WorkoutPerPage));
        }
        public IEnumerable<Workout> PaginatedWorkout()
        {
            int start = (CurrentPage - 1) * WorkoutPerPage;
            return Workouts.OrderBy(b => b.WorkoutId).Skip(start).Take(WorkoutPerPage);
        }
    }
}
