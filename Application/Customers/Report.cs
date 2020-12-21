using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Customers {
    public class Report {
        public class Query : IRequest<ReportDTO> { }
        public class Handler : IRequestHandler<Query, ReportDTO> {
            private readonly DataContext _context;
            public Handler (DataContext context) {
                _context = context;
            }

            public async Task<ReportDTO> Handle(Query request, CancellationToken cancellationToken)
            {
                var male_count = await _context.Customer.Where(x => x.Gender == "Male").Select(x => x.DOB.Year).ToArrayAsync();
                var female_count = await _context.Customer.Where(x => x.Gender == "Female").Select(x => x.DOB.Year).ToArrayAsync();
                var other_count = await _context.Customer.Where(x => x.Gender == "Other").Select(x => x.DOB.Year).ToArrayAsync();
                var report = new ReportDTO
                {
                    Male = Math.Round(DateTime.Now.Year - male_count.Average(), 2),
                    Female = Math.Round(DateTime.Now.Year - female_count.Average(), 2),
                    Other = Math.Round(DateTime.Now.Year - other_count.Average(), 2)
                };
                return report;
            }
        }
    }
}