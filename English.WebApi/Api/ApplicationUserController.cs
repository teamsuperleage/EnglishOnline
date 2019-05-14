using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace English.WebApi.Api
{
    public class ApplicationUserController : ApiController
    {
        // GET api/<controller>
        IApplicationUserService _applicationUserService;

        public CourseController(ICourseService courseService)
        {
            this._applicationUserService = courseService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            var listCategory = _applicationUserService.GetAll();
            HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listCategory);
            return response;

        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, Course courseVm)
        {
            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {
                request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            else
            {
                var category = _applicationUserService.Add(courseVm);
                _applicationUserService.Save();
                response = request.CreateResponse(HttpStatusCode.Created, category);
            }
            return response;
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, Course courseVm)
        {

            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {
                request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            else
            {
                _applicationUserService.Update(courseVm);
                _applicationUserService.Save();

                response = request.CreateResponse(HttpStatusCode.OK);

            }
            return response;

        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {
                request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            else
            {
                _applicationUserService.Delete(id);
                _applicationUserService.Save();

                response = request.CreateResponse(HttpStatusCode.OK);

            }
            return response;

        }
    }
}