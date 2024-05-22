using CrudMVCClean.Models;
using CrudMVCClean.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CrudMVCClean.Controllers
{
	public class FacesController : Controller
	{
		private readonly FaceRepository _faceRepository;
		public FacesController(FaceRepository faceRepository)
		{
			_faceRepository = faceRepository;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return PartialView("_FaceCreation");
		}
		[HttpPost]
		public async Task<IActionResult> Create(Face face)
		{
			await _faceRepository.CreateAsync(face);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return PartialView("_FaceDisplayInput");
		}
		[HttpGet]
		public async Task<IActionResult> Display(int Id)
		{
			var face = await _faceRepository.GetAsync(Id);
			ViewBag.Face = face.Content;
			return PartialView("_FaceDisplay");
		}
	}
}
