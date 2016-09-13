﻿using TramlineFive.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TramlineFive.DataAccess.DomainLogic;
using TramlineFive.DataAccess.Repositories;

namespace TramlineFive.ViewModels
{
    public class SettingsViewModel : NotifyingModel
    {
        public bool PushNotifications
        {
            get
            {
                string value = SettingsManager.ReadValue("PushNotifications");
                if (value == null)
                    return false;

                return Boolean.Parse(value);
            }
            set
            {
                SettingsManager.UpdateValue("PushNotifications", value);
                OnPropertyChanged("PushNotifications");
            }
        }

        public bool LiveTile
        {
            get
            {
                string value = SettingsManager.ReadValue("LiveTile");
                if (value == null)
                    return false;

                return Boolean.Parse(value);
            }
            set
            {
                SettingsManager.UpdateValue("LiveTile", value);
                OnPropertyChanged("LiveTile");
            }
        }

        public async Task ClearHistoryAsync()
        {
            await HistoryDO.ClearAllAsync();
        }

        public async Task FetchLinesAsync(string code)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                
            }
        }
    }
}
