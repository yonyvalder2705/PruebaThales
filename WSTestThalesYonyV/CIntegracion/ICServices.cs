using CModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIntegracion
{
    public interface ICServices
    {
        List<EmployModel> ExecuteServiceEmploy();
        EmployModel ExecuteServiceEmployByid(int id);
    }
}
