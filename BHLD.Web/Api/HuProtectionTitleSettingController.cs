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
    [RoutePrefix("api/HuProtectionTitleSetting")]
    public class HuProtectionTitleSettingController : APIControllerBase
    {
        Ihu_protection_title_settingServices _Protection_Title_SettingServices;
        public HuProtectionTitleSettingController(IErrorService errorService, Ihu_protection_title_settingServices ihu_Protection_Title_SettingServices) : base(errorService)
        {
            this._Protection_Title_SettingServices = ihu_Protection_Title_SettingServices;
        }
        [Route("Post")]
        public HttpResponseMessage Post(HttpRequestMessage request, hu_protection_title_setting hu_Protection_Title_Setting)
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
                    var district = _Protection_Title_SettingServices.Add(hu_Protection_Title_Setting);
                    _Protection_Title_SettingServices.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.Created, district);
                }
                return response;
            }
            );
        }
        [Route("Put")]
        public HttpResponseMessage Put(HttpRequestMessage request, hu_protection_title_setting hu_Protection_Title_Setting)
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
                    _Protection_Title_SettingServices.Update(hu_Protection_Title_Setting);
                    _Protection_Title_SettingServices.SaveChanges();
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
                    _Protection_Title_SettingServices.Delete(id);
                    _Protection_Title_SettingServices.SaveChanges();
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

                var listTitle = _Protection_Title_SettingServices.GetAll();

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listTitle);

                return response;
            }
            );
        }
    }
}