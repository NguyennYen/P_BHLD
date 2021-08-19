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
    [RoutePrefix("api/HuProtectionEmp")]
    public class HuProtectionEmpController : APIControllerBase
    {
        Ihu_protection_empServices _Protection_EmpServices;
        public HuProtectionEmpController(IErrorService errorService, Ihu_protection_empServices ihu_Protection_EmpServices) : base(errorService)
        {
            this._Protection_EmpServices = ihu_Protection_EmpServices;
        }
        [Route("Post")]
        public HttpResponseMessage Post(HttpRequestMessage request, hu_protection_emp hu_Protection_Emp)
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
                    var district = _Protection_EmpServices.Add(hu_Protection_Emp);
                    _Protection_EmpServices.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.Created, district);
                }
                return response;
            }
            );
        }
        [Route("Put")]
        public HttpResponseMessage Put(HttpRequestMessage request, hu_protection_emp hu_Protection_Emp)
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
                    _Protection_EmpServices.Update(hu_Protection_Emp);
                    _Protection_EmpServices.SaveChanges();
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
                    _Protection_EmpServices.Delete(id);
                    _Protection_EmpServices.SaveChanges();
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

                var listTitle = _Protection_EmpServices.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listTitle);

                return response;
            }
            );
        }
    }
}