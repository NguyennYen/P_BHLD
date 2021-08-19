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
    [RoutePrefix("api/huemployeecv")]
    public class HuEmployeeCvController : APIControllerBase
    {
        Ihu_employee_cvServices _Employee_CvServices;
        public HuEmployeeCvController(IErrorService errorService, Ihu_employee_cvServices ihu_Employee_CvServices) : base(errorService)
        {
            this._Employee_CvServices = ihu_Employee_CvServices;
        }
        public HttpResponseMessage Post(HttpRequestMessage request, hu_employee_cv hu_Employee_Cv)
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
                    var employee = _Employee_CvServices.Add(hu_Employee_Cv);
                    _Employee_CvServices.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.Created, employee);
                }
                return response;
            }
            );
        }

        public HttpResponseMessage Put(HttpRequestMessage request, hu_employee_cv hu_Employee_Cv)
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
                    _Employee_CvServices.Update(hu_Employee_Cv);
                    _Employee_CvServices.SaveChanges();
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
                    _Employee_CvServices.Delete(id);
                    _Employee_CvServices.SaveChanges();
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

                var listTitle = _Employee_CvServices.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listTitle);

                return response;
            }
            );
        }
    }
}