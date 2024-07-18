using AutoMapper;
using CaterServMongoDb.Dtos.ProductDtos;
using CaterServMongoDb.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CaterServMongoDb.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, IMapper mapper, ICategoryService categoryService)
        {
            _productService = productService;
            _mapper = mapper;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _productService.GetAllProducts();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct() 
        { 
            var categoryList = await _categoryService.GetAllCategories();

            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryName
                                               }).ToList();

            ViewBag.category = categories;


            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProduct(createProductDto);
            return RedirectToAction("Index");
        }



        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProduct(id);
            return RedirectToAction("Index");

        }



        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {

            var categoryList = await _categoryService.GetAllCategories();

            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryName
                                               }).ToList();

            ViewBag.category = categories;

            var value = await _productService.GetProductById(id);

            var product = _mapper.Map<UpdateProductDto>(value);
            return View(product);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProduct(updateProductDto);
            return RedirectToAction("Index");
        }
    }
}
