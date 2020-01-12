﻿using GoVote.Data;
using GoVote.DTO;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GoVote.Business.Handlers
{
    public class GetTop10CityStatisticsHandler : IRequestHandler<GetTop10CityStatistics, Dictionary<string, float>>
    {
        private readonly CitizenDatabaseContext _context;

        public GetTop10CityStatisticsHandler(CitizenDatabaseContext context)
        {
            _context = context;
        }
        public async Task<Dictionary<string, float>> Handle(GetTop10CityStatistics request, CancellationToken cancellationToken)
        {
            var citizens = await _context.Citizens.ToListAsync();
            var statistics = new Dictionary<string, float>();

            foreach (Citizen citizen in citizens)
            {
                if (citizen.VotedFor != new System.Guid("00000000-0000-0000-0000-000000000000"))
                {
                    if (!statistics.ContainsKey(citizen.City))
                    {
                        statistics[citizen.City] = 1;
                    }
                    else
                        statistics[citizen.City] += 1;
                }
               
            }

            var statisticsList = statistics.ToList();
            statisticsList.Sort((count1, count2) => count1.Value.CompareTo(count2.Value));

            var top10List = statisticsList.Take(10);
            return top10List.ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
