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
    [RoutePrefix("api/OtherListType")]
    public class OtherListTypeController : APIControllerBase
    {
        Iot_other_list_typeServices _Other_List_TypeServices;
        public OtherListTypeController(IErrorService errorService, Iot_other_list_typeServices list_TypeServices) : base(errorService)
        {
            this._Other_List_TypeServices = list_TypeServices;
        }
        [Route("Post")]
        public HttpResponseMessage Post(HttpRequestMessage request, ot_other_list_type other_List_Type)
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
                    var district = _Other_List_TypeServices.Add(other_List_Type);
                    _Other_List_TypeServices.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.Created, district);
                }
                return response;
            }
            );
        }
        [Route("Put")]
        public HttpResponseMessage Put(HttpRequestMessage request, ot_other_list_type other_List_Type)
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
                    _Other_List_TypeServices.Update(other_List_Type);
                    _Other_List_TypeServices.SaveChanges();
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
                    _Other_List_TypeServices.Delete(id);
                    _Other_List_TypeServices.SaveChanges();
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

                var listTitle = _Other_List_TypeServices.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listTitle);

                return response;
            }
            );
        }
    }
}