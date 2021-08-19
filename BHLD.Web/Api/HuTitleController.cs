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
    [RoutePrefix("api/hutitle")]
    public class HuTitleController : APIControllerBase
    {
        Ihu_titleServices _ihu_TitleServices; 
        public HuTitleController(IErrorService errorService, Ihu_titleServices ihu_TitleServices) : base(errorService)
        {
            this._ihu_TitleServices = ihu_TitleServices;
        }
        public HttpResponseMessage Post(HttpRequestMessage request, hu_title hu_Title)
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
                     var title= _ihu_TitleServices.Add(hu_Title);
                    _ihu_TitleServices.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.Created, title);
                }
                return response;
            }
            );
        }

        public HttpResponseMessage Put(HttpRequestMessage request, hu_title hu_Title)
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
                    _ihu_TitleServices.Update(hu_Title);
                    _ihu_TitleServices.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            }
            );
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int  id)
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
                    _ihu_TitleServices.Delete(id);
                    _ihu_TitleServices.SaveChanges();
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
   
                var listTitle = _ihu_TitleServices.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listTitle);

                return response;
            }
            );
        }
    }
}