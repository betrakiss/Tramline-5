﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TramlineFive.Common.Models;

namespace TramlineFive.ViewModels
{
    public class ArrivalViewModel : NotifyingViewModel
    {
        public ArrivalViewModel(Arrival arrival)
        {
            VehicleNumber = arrival.VehicleNumber;
            Timings = arrival.Timings;
            Direction = arrival.Direction;
            StopTitle = arrival.StopTitle;
        }

        private int vehicleNumber;
        public int VehicleNumber
        {
            get
            {
                return vehicleNumber;
            }

            set
            {
                vehicleNumber = value;
                OnPropertyChanged("VehicleNumber");
            }
        }

        private string[] timings;
        public string[] Timings
        {
            get
            {
                return timings;
            }
            set
            {
                if (value != null)
                {
                    timings = value;
                    OnPropertyChanged("Timings");
                }
            }
        }

        private string direction;
        public string Direction
        {
            get
            {
                return direction;
            }
            set
            {
                if (value != null)
                {
                    direction = value;
                    OnPropertyChanged("Direction");
                }
            }
        }

        private string stopTitle;
        public string StopTitle
        {
            get
            {
                return stopTitle;
            }
            set
            {
                if (value != null)
                {
                    stopTitle = value;
                    OnPropertyChanged("StopTitle");
                }
            }
        }
    }
}
