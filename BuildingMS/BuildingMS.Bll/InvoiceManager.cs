using BuildingMS.Dal.Abstract;
using BuildingMS.Entity.Dto;
using BuildingMS.Entity.Models;
using BuildingMS.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Bll
{
    public class InvoiceManager : GenericManager<Invoice, DtoInvoice>, IInvoiceService
    {
        public readonly IInvoiceRepository ınvoiceRepository;

        public InvoiceManager(IServiceProvider service) : base(service)
        {
            ınvoiceRepository = service.GetService<IInvoiceRepository>();

        }
    }
}
