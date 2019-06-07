using DemoApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Domain.Scheduler
{
    public interface IScheduler
    {
        Task<bool> ProcessUserAlbumScheduler();
    }
}
