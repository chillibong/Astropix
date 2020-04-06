using AstroPix.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AstroPix.Shared.ViewModels
{
    public class ImagesViewModel
    {
        IAstrobinService astrobinService;
        //public string url = "https://www.astrobin.com/api/v1/imageoftheday/?&api_key=0c8d7af70f0f076aaf401597f5b5f53a829e62f0&api_secret=fceff09657deff0476d7e90709e50fb7489a03c7&format=json";

        public ImagesViewModel (IAstrobinService service)
        {
            astrobinService = service;
        }

        public Task<ImageResults> GetTasksAsync()
        {
            return astrobinService.RefreshDataAsync();
        }
    }
}
