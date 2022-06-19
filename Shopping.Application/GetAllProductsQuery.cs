using MediatR;
using Shopping.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application
{
    public class GetAllProductsQuery: IRequest<List<Product>>
    {

    }
}
