﻿using Microsoft.AspNetCore.SignalR;
using SmartAmperesServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartAmperesServer.HubConfig
{
    public class ChartHub: Hub
    {
        public async Task BroadcastChartData(List<ChartModel> data) => await Clients.All.SendAsync("broadcastchartdata", data);
    }
}
