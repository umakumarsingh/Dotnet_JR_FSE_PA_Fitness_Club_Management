using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessClubManagement.Entities
{
    public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }
        public string Name { get; set; }
        [Display(Name ="Main Goal")]
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
        [Display(Name = "Time PerWork kout")]
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
    }
}
