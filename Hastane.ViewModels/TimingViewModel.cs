﻿using Hastane.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.ViewModels
{
    public class TimingViewModel
    {
        public int Id { get; set; }
        public ApplicationUser Doctor { get; set; }
        public DateTime ScheduleDate { get; set; }
        public int MorningShiftStartTime { get; set; }
        public int MorningShiftEndTime { get; set; }
        public int AfternoonShiftStartTime { get; set; }
        public int AfternoonShiftEndTime { get; set; }
        public int Duration { get; set; }
        public Status Status { get; set; }
        List<SelectListItem> morningShiftStartTime = new List<SelectListItem>();
        List<SelectListItem> morningShiftEndTime = new List<SelectListItem>();
        List<SelectListItem> afternoonShiftStartTime = new List<SelectListItem>();
        List<SelectListItem> afternoonShiftEndTime = new List<SelectListItem>();

        public TimingViewModel()
        {

        }
        public TimingViewModel(Timing model)
        {
            Id = model.Id;
            ScheduleDate = model.ScheduleDate;
            MorningShiftStartTime = model.MorningShiftStartTime;
            MorningShiftEndTime = model.MorningShiftEndTime;
            AfternoonShiftStartTime = model.AfternoonShiftStartTime;
            AfternoonShiftEndTime = model.AfternoonShiftEndTime;
            Duration = model.Duration;
            Status = model.Status;
            Doctor = model.Doctor;
        }
        public Timing ConvertViewModel(TimingViewModel model)
        {
            return new Timing
            {
                Id = model.Id,
                ScheduleDate = model.ScheduleDate,
                MorningShiftStartTime = model.MorningShiftStartTime,
                MorningShiftEndTime = model.MorningShiftEndTime,
                AfternoonShiftStartTime = model.AfternoonShiftStartTime,
                AfternoonShiftEndTime = model.AfternoonShiftEndTime,
                Duration = model.Duration,
                Status = model.Status,
                Doctor = model.Doctor
            };




        }

    }
}
