using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Customers {
    public class Create {
        public class Command : IRequest {
            public int Id { get; set; }
            public string First_name { get; set; }
            public string Last_name { get; set; }
            public DateTime DOB { get; set; }
            public string Gender { get; set; }
        }

        public class Handler : IRequestHandler<Command> {
            private readonly DataContext _context;
            public Handler (DataContext context) {
                _context = context;
            }

            public async Task<Unit> Handle (Command request, CancellationToken cancellationToken) {
                var customer = new Customer
                {
                    Id = request.Id,
                    First_name = request.First_name,
                    Last_name = request.Last_name,
                    DOB = request.DOB,
                    Gender = request.Gender   
                };
                _context.Customer.Add(customer);
                var success = await _context.SaveChangesAsync() > 0;
                if(success) return Unit.Value;
                throw new Exception("Problem saving changes");
            }
        }
    }
}