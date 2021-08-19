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
    [RoutePrefix("api/huorganization")]
    public class HuOrganizationController : APIControllerBase
    {
        Ihu_organizationServices _OrganizationServices;
        public HuOrganizationController(IErrorService errorService, Ihu_organizationServices ihu_OrganizationServices) : base(errorService)
        {
            this._OrganizationServices = ihu_OrganizationServices;
        }
        [Route("Post")]
        public HttpResponseMessage Post(HttpRequestMessage request, hu_organization hu_Organization)
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
                    var district = _OrganizationServices.Add(hu_Organization);
                    _OrganizationServices.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.Created, district);
                }
                return response;
            }
            );
        }
        [Route("Put")]
        public HttpResponseMessage Put(HttpRequestMessage request, hu_organization hu_Organization)
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
                    _OrganizationServices.Update(hu_Organization);
                    _OrganizationServices.SaveChanges();
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
                    _OrganizationServices.Delete(id);
                    _OrganizationServices.SaveChanges();
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

                var listTitle = _OrganizationServices.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listTitle);

                return response;
            }
            );
        }
    }
}