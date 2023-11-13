using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITELEC1C_FinalLabAct3.Data;
using ITELEC1C_FinalLabAct3.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ITELEC1C_FinalLabAct3.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        // GET: /<countroller>/
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(loginInfo.Username, loginInfo.Password, loginInfo.RememberMe, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Instructor");
            }
            else {
                ModelState.AddModelError("", "Failed to Login");
            }
            return View(loginInfo);
        }

        public async Task<IActionResult> Logout() { 
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login","Account");
        }

        [HttpGet]
        public IActionResult Register() { 
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel userEnteredData)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User();
                newUser.UserName = userEnteredData.Username;
                newUser.FirstName = userEnteredData.FirstName;
                newUser.LastName = userEnteredData.LastName;
                newUser.Email = userEnteredData.Email;
                newUser.PhoneNumber = userEnteredData.Phone;

                var result = await _userManager.CreateAsync(newUser, userEnteredData.Password);
                //var result = await _signInManager.PasswordSignInAsync(userEnteredData.Username, userEnteredData.Password,false,false);

                if (result.Succeeded)
                {
                    //return RedirectToAction("Index", "Instructor");
                    return RedirectToAction("Login", "Account");
                }
                else 
                {
                    foreach (var error in result.Errors) { 
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(userEnteredData);
        }
    }
}
