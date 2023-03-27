﻿using Examination_system.Models;
using Examination_system.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace Examination_system.Controllers
{
    public class LoginController : Controller
    {
        IqexamContext context = new IqexamContext();

        public IActionResult Index()
        {

            return View();
        }

            [HttpPost]
        public IActionResult Index(LoginMV MV )
        {

			if (ModelState.IsValid == true)
			{
                if (MV.Type )
                {


                }
                else
                {


                  List<Instructor> instructors = context.Instructors.FromSql($"Sp_InstructorValidNamePassword {MV.UserName},{MV.Password} ").ToList();
                    if (instructors.Count() > 0 && instructors[0].InsName == MV.UserName && instructors[0].InsPass ==MV.Password)
                    {

                        return RedirectToAction();
                    }
                    else
                    {
                       
                    }


                }
			}


			return View();
        }
    }
}
