using AstroPix.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AstroPix.Shared
{
    public interface IAstrobinService
    {
        Task<ImageResults> RefreshDataAsync();
    }
}
