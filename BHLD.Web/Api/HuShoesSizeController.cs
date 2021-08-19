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
    [RoutePrefix("api/HuShoesSize")]
    public class HuShoesSizeController : APIControllerBase
    {
        Ihu_shoes_sizeServices _Shoes_SizeServices;
        public HuShoesSizeController(IErrorService errorService, Ihu_shoes_sizeServices ihu_Shoes_SizeServices) : base(errorService)
        {
            this._Shoes_SizeServices = ihu_Shoes_SizeServices;
        }
        [Route("Post")]
        public HttpResponseMessage Post(HttpRequestMessage request, hu_shoes_size hu_Shoes_Size)
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
                    var district = _Shoes_SizeServices.Add(hu_Shoes_Size);
                    _Shoes_SizeServices.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.Created, district);
                }
                return response;
            }
            );
        }
        [Route("Put")]
        public HttpResponseMessage Put(HttpRequestMessage request, hu_shoes_size hu_Shoes_Size)
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
                    _Shoes_SizeServices.Update(hu_Shoes_Size);
                    _Shoes_SizeServices.SaveChanges();
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
                    _Shoes_SizeServices.Delete(id);
                    _Shoes_SizeServices.SaveChanges();
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

                var listTitle = _Shoes_SizeServices.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listTitle);

                return response;
            }
            );
        }
    }
}