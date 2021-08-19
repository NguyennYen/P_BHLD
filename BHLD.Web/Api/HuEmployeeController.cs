using BHLD.Model.Models;
using BHLD.Services;
using BHLD.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BHLD.Web.Api
{
    [RoutePrefix("api/huemployee")]
    public class HuEmployeeController : APIControllerBase
    {
        Ihu_employeeServices _EmployeeServices;
        public HuEmployeeController(IErrorService errorService, Ihu_employeeServices ihu_EmployeeServices) : base(errorService)
        {
            this._EmployeeServices = ihu_EmployeeServices;
        }
        public HttpResponseMessage Post(HttpRequestMessage request, hu_employee hu_Employee)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var employee = _EmployeeServices.Add(hu_Employee);
                    _EmployeeServices.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.Created, employee);
                }
                return response;
            }
            );
        }

        public HttpResponseMessage Put(HttpRequestMessage request, hu_employee hu_Employee)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _EmployeeServices.Update(hu_Employee);
                    _EmployeeServices.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            }
            );
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _EmployeeServices.Delete(id);
                    _EmployeeServices.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            }
            );
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {

                var listTitle = _EmployeeServices.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listTitle);

                return response;
            }
            );
        }
    }
}