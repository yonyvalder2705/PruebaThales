﻿using CModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public interface IDEmploy
    {
        List<EmployModel> ListEmploy();

        EmployModel EmployById(int id);
    }
}
