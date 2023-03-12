using APIDashboard.CrossCutting.Models;
using APIDashboard.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDashboard.Domain.Orchestrators
{
    public class APODOrchestrator
    {
        private NASARepository nasaRepository;

        public APODOrchestrator()
        {
            nasaRepository = new NASARepository();
        }

        public APOD GetAPOD()
        {
            APOD apod = nasaRepository.GetAPOD().Result;

            if (apod == null)
            {
                return null;
            }

            return apod;
        }
    }
}
