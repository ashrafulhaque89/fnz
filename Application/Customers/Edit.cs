using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.Customers {
    public class Edit {
        public class Command : IRequest {
            public int Id { get; set; }
            public string First_name { get; set; }
            public string Last_name { get; set; }
            public DateTime? DOB { get; set; }
            public string Gender { get; set; }
        }

        public class Handler : IRequestHandler<Command> {
            private readonly DataContext _context;
            public Handler (DataContext context) {
                _context = context;
            }

            public async Task<Unit> Handle (Command request, CancellationToken cancellationToken) {

                var customer = await _context.Customer.FindAsync(request.Id);

                if(customer == null)
                {
                    throw new Exception("Could not find user");
                }

                customer.First_name = request.First_name ?? customer.First_name;
                customer.Last_name = request.Last_name ?? customer.Last_name;
                customer.DOB = request.DOB ?? customer.DOB;
                customer.Gender = request.Gender ?? customer.Gender;

                var success = await _context.SaveChangesAsync() > 0;

                if(success) return Unit.Value;

                throw new Exception("Problem updating changes");
            }
        }
    }
}