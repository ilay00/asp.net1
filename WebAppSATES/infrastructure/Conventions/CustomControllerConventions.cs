using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSATES.infrastructure.Conventions
{
    public class CustomControllerConventions:IControllerModelConvention
    {

        public void Apply(ControllerModel controller)
        {

            //controller.ControllerName

        }
    }
}
