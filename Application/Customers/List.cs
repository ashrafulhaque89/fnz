using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Customers {
    public class List {
        public class Query : IRequest<List<CustomerDTO>> { }
        public class Handler : IRequestHandler<Query, List<CustomerDTO>> {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler (DataContext context, IMapper mapper) {
                _mapper = mapper;
                _context = context;
            }

            public async Task<List<CustomerDTO>> Handle (Query request, CancellationToken cancellationToken) {
                var customers = await _context.Customer.ToListAsync();
                return _mapper.Map<List<Customer>,List<CustomerDTO>>(customers);
            }
        }
    }
}