using AutoMapper;
using BHLD.Model.Models;
using BHLD.Services;
using BHLD.Web.Infrastructure.Core;
using BHLD.Web.Infrastructure.Extensions;
using BHLD.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BHLD.Web.Api
{
    [RoutePrefix("api/hu_title")]
    [Authorize]
    public class Hu_titleController : APIControllerBase
    {
        Ihu_titleServices _hu_titleServices;
        public Hu_titleController(IErrorService errorService, Ihu_titleServices hu_titleServices) :
            base(errorService)
        {
            this._hu_titleServices = hu_titleServices;
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listHu_title = _hu_titleServices.GetAll();

                var listHuTileVm = Mapper.Map<List<HuTitleViewModel>>(listHu_title);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listHuTileVm);

                return response;
            });
        }
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, HuTitleViewModel huTitleVM)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    hu_title new_hu_tile = new hu_title();
                    new_hu_tile.UpdateHuTitle(huTitleVM);

                    var category = _hu_titleServices.Add(new_hu_tile);
                    _hu_titleServices.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, category);
                }
                return response;
            });
        }
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, HuTitleViewModel huTitleVM)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var post_hu_tile = _hu_titleServices.GetById(huTitleVM.id);
                    post_hu_tile.UpdateHuTitle(huTitleVM);
                    _hu_titleServices.Update(post_hu_tile);
                    _hu_titleServices.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _hu_titleServices.Delete(id);
                    _hu_titleServices.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
    }

    
}
