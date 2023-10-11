using Domain.Entities;
using Domain.Model;
using ONG.Domain.Seedwork.Notify;
using ONG.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.Domain.Seedwork
{
    public class BaseService<TDomain, TModel> : BaseAdapter<TDomain, TModel>
    {
    }
}
