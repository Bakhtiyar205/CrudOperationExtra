using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.Utilities.Files;
using FrontToBack.Utilities.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _enviroment;
        public SliderController(AppDbContext context, IWebHostEnvironment enviroment)
        {
            _context = context;
            _enviroment = enviroment;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.Where(m => !m.IsDeleted).ToListAsync();
            return View(sliders);
        }


        //For Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();
            if (!slider.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Only image type is acceptible");
                return View();
            }
            if (!slider.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "The image should be less than 200KB");
                return View();
            }

            string fileName = Guid.NewGuid().ToString() + "_" + slider.Photo.FileName;

            string path = Helper.GetFilePath(_enviroment.WebRootPath, "assets/img", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await slider.Photo.CopyToAsync(stream);
            }


            slider.Image = fileName;
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        //For Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await GetSliderById(id);

            if (slider == null) return NotFound();

            string path = Helper.GetFilePath(_enviroment.WebRootPath, "assets/img", slider.Image);

            Helper.DeleteFile(path);

            _context.Sliders.Remove(slider);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private async Task<Slider> GetSliderById(int id)
        {
            return await _context.Sliders.FindAsync(id);
        }

        //For Update 
        public async Task<IActionResult> Update(int id)
        {
            Slider slider = await _context.Sliders.FindAsync(id);

            if (slider == null) NotFound();

            return View(slider);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id,Slider slider)
        {
            Slider dbSlider = await GetSliderById(id);

            string path = Helper.GetFilePath(_enviroment.WebRootPath, "assets/img", dbSlider.Image);

            Helper.DeleteFile(path);

            if (!slider.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Only image type is accebtible");
                return View(slider);
            }

            if (!slider.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Must be Less than 200KB");
                return View(slider);
            }

            string fileName = Guid.NewGuid().ToString() + "_" + slider.Photo.FileName;

            string pathNew = Helper.GetFilePath(_enviroment.WebRootPath, "assets/img", fileName);

            using(FileStream stream = new FileStream(pathNew, FileMode.Create))
            {
                await slider.Photo.CopyToAsync(stream);
            }

            dbSlider.Image = fileName;
            await _context.SaveChangesAsync();

            return RedirectToAction();
        }

    }
}
