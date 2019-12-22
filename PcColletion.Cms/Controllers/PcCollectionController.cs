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
    public class PcCollectionController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public PcCollectionController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<IActionResult> PcCollectionManagement()
        {

            var result = await _itemRepository.GetListAsync();
            return View(result);
        }

        public async Task<IActionResult> Create()
        {

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(Item model)
        {
            var result = await _itemRepository.SaveOrUpdateAsync(model);
            if (result.success)
                return View("PcCollectionManagement");
            return View(model);

        }
        public async Task<IActionResult> Edit(int Id)
        {
            var result = await _itemRepository.FindAsync(Id);

            return View(result);

        }

        [HttpPost]

        public async Task<IActionResult> Edit(Item model)
        {
            model.CreateDate = DateTime.UtcNow;
            var result = await _itemRepository.SaveOrUpdateAsync(model);
            if (result.success)
                return View("PcCollectionManagement");
            return View(model);


        }
    }
}
