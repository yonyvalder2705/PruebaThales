using CModelos;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace CIntegracion
{
    public class CServices : ICServices
    {
        private readonly string UrlServiceEmploy;

        public CServices()
        {
            UrlServiceEmploy = ConfigurationManager.AppSettings.Get("UrlServiceEmploy");
        }
        public List<EmployModel> ExecuteServiceEmploy()
        {
            var restClient = new RestClient(UrlServiceEmploy);
            var restRequest = new RestRequest("v1/employees/", Method.GET);
            RestResponse<byte[]> restResponse = new RestResponse<byte[]>();
            IRestResponse responseMessage = restClient.Execute(restRequest);
            try
            {
                if (responseMessage.StatusCode.Equals(System.Net.HttpStatusCode.OK) && responseMessage.Content != null)
                {
                    var response =  JsonConvert.DeserializeObject<EmployWrapper>(responseMessage.Content);
                    return response.data;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public EmployModel ExecuteServiceEmployByid(int id)
        {
            var restClient = new RestClient(UrlServiceEmploy);
            var restRequest = new RestRequest(string.Format("v1/employees/{0}", id), Method.POST);
            RestResponse<byte[]> restResponse = new RestResponse<byte[]>();
            IRestResponse responseMessage = restClient.Execute(restRequest);
            try
            {
                if (responseMessage.StatusCode.Equals(System.Net.HttpStatusCode.OK) && responseMessage.Content != null)
                {
                    var response = JsonConvert.DeserializeObject<EmployWrapper>(responseMessage.Content);
                    return response.data.FirstOrDefault();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
