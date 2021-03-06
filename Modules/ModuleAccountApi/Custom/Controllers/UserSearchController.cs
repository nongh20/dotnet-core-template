﻿
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ModuleAccount.Services;
using ModuleAccountApi.Generated.RequestEntities;
using ModuleAccount.Generated.Entities;
using ModuleAccount.IServices;
using CoreCommon.Data.Domain.Business;using CoreCommon.Data.Domain.Models;using CoreCommon.Data.Domain.Attributes;

namespace ModuleAccountApi.Generated.Controllers
{
    [RoleAction("AccountApi","User", null)]
    [Route("AccountApi/UserSearch")]
    [ApiController]
    public partial class UserSearchController
    {
        [RoleAction("list")]
        [HttpPost("all")]
        public ActionResult Search(ApiRequestListModel<UserSearchRequest> model)
        {
            return Search0(model);
        }
        [RoleAction("get")]
        [HttpGet("get/{id}")]
        public ActionResult Get(int id)
        {
            return Get0(id);
        }
        /*[RoleAction("get")]
        [HttpPost("gets")]
        public IActionResult Gets(List<int> ids)
        {
            var response = UserBusinessLogic.FindBy(x => ids.Contains(x.Id));
            // return SuccessResponse(response.Value.Select(x => new { x.Id, x.Name }));
            return Json(response);
        }*/
        [RoleAction("new")]
        [HttpPost("new")]
        public ActionResult Create(UserEntityModel model)
        {
            return Create0(model);
        }
        [RoleAction("edit")]
        [HttpPost("update")]
        public ActionResult Update(UserEntityModel model)
        {
            return Update0(model);
        }
    }
}
