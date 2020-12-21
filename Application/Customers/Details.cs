using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;
using System.Linq;

namespace Application.Customers {
    public class Details {
        public class Query : IRequest<CustomerDTO> {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, CustomerDTO> {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler (DataContext context, IMapper mapper) {
                _mapper = mapper;
                _context = context;
            }

            public async Task<CustomerDTO> Handle(Query request, CancellationToken cancellationToken) {

                var customer = await _context.Customer.FindAsync(request.Id);

                if (customer == null)
                    throw new Exception ("Not found");

                var customerToReturn = _mapper.Map<Customer, CustomerDTO>(customer);
                return customerToReturn;
            }
        }
    }
}