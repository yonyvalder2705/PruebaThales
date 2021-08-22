using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CModelos;
using CIntegracion;
using Newtonsoft.Json;
using System.IO;
using System.Configuration;

namespace CDatos
{
    public class DEmploy : IDEmploy
    {
        private readonly string urlarchivojson;
        ICServices objintegracion = new CServices();
        public DEmploy()
        {
            urlarchivojson = ConfigurationManager.AppSettings.Get("PathBackUp");
        }

        public List<EmployModel> ListEmploy()
        {
            EmployModel employModel = new EmployModel();
            EmployWrapper wraper = new EmployWrapper();
            List<EmployModel> LstEmploy = new List<EmployModel>();
            LstEmploy = objintegracion.ExecuteServiceEmploy();

            if(LstEmploy == null)
            {
                StreamReader r = new StreamReader(urlarchivojson);
                string jsonString = r.ReadToEnd();
                wraper = JsonConvert.DeserializeObject<EmployWrapper>(jsonString);
                LstEmploy = wraper.data;

            }

            return LstEmploy;
        }

        public EmployModel EmployById(int id)
        {
            EmployModel employModel = new EmployModel();
            EmployWrapper wrapper = new EmployWrapper();
            employModel = objintegracion.ExecuteServiceEmployByid(id);

            if (employModel == null)
            {
                StreamReader r = new StreamReader(urlarchivojson);
                string jsonString = r.ReadToEnd();
                wrapper = JsonConvert.DeserializeObject<EmployWrapper>(jsonString);
                employModel = wrapper.data.Where(x=> x.Id == id).FirstOrDefault();
                if(employModel == null)
                {
                    employModel = new EmployModel();
                }
            }

            return employModel;
        }


    }
}
