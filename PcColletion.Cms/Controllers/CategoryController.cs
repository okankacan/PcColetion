using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PcColletion.InfraStructure.Model;
using PcColletion.InfraStructure.Repository.Interface;

namespace PcColletion.Cms.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategorieRepository _categorieRepository;

        public CategoryController(ICategorieRepository categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }

        public async Task<IActionResult> CategoryManagement()
        {
            var result =  await _categorieRepository.GetListAsync();
         
            return View(result);
        }

        public async Task<IActionResult> Create()
        {
 
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(Categorie model)
        {
            var result = await _categorieRepository.SaveOrUpdateAsync(model);
            if (result.success)
                return View("CategoryManagement");
            return View(model);

        }
        public async Task<IActionResult> Edit(int Id)
        {
            var result = await _categorieRepository.FindAsync(Id);

            return View(result);

        }

        [HttpPost]

        public async Task<IActionResult> Edit(Categorie model)
        {
            model.CreateDate = DateTime.UtcNow;
            var result = await _categorieRepository.SaveOrUpdateAsync(model);
            if (result.success)
                return View("CategoryManagement");
            return View(model);

 
        }
    }
}