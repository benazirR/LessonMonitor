﻿using LessonMonitor.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace LessonMonitor.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeworksController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetHomeWorks(Homework model)
        {
            return Ok(new {Successful = 1});
        }

        //[HttpGet("model")]
        //public string[] GetHomeworkTypeProperties()
        //{
        //    var homeworksModel = typeof(Homework);

        //    List<string> metaDataArray = new List<string>();

        //    metaDataArray.Add(homeworksModel.Namespace.ToString());

        //    foreach (var prop in homeworksModel.GetProperties())
        //    {
        //        metaDataArray.Add(prop.ToString());

        //        foreach (var custAttr in prop.GetCustomAttributes())
        //        {
        //            metaDataArray.Add(custAttr.ToString());
        //        }
        //    }

        //    foreach (var mInfo in homeworksModel.GetMembers())
        //    {
        //        metaDataArray.Add(mInfo.ToString());
        //    }

        //    metaDataArray.Add(homeworksModel.ToString());

        //    metaDataArray.Add(homeworksModel.Assembly.GetName().ToString());

        //    var assemblyInfo = typeof(HomeworksController).Assembly;

        //    metaDataArray.Add(assemblyInfo.FullName);

        //    foreach (var AssemblyIN in assemblyInfo.GetReferencedAssemblies())
        //    {
        //        metaDataArray.Add(AssemblyIN.ToString());
        //    }

        //    foreach (var curDomain in AppDomain.CurrentDomain.GetAssemblies())
        //    {
        //        metaDataArray.Add(curDomain.ToString());

        //    }

        //    return metaDataArray.ToArray();
        //}

    }
}
