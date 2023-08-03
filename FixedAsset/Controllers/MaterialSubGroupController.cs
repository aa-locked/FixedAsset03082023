using FixedAsset.DataAccess.Data;
using FixedAsset.Model.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FixedAsset.Controllers
{
    public class MaterialSubGroupController : Controller
    {
        private readonly FixedAssetDBContext _fixedAssetDBContext;

        public MaterialSubGroupController(FixedAssetDBContext fixedAssetDBContext)
        {
            _fixedAssetDBContext = fixedAssetDBContext;
        }

        // GET: MaterialSubGroupController
        public ActionResult Index()
        {
          var subgrpresult=  _fixedAssetDBContext.tFAMtrlSubGrp.ToList();
            return View(subgrpresult);
        }        

        // GET: MaterialSubGroupController/Create
        public ActionResult Create()
        {
            IEnumerable<SelectListItem> MtrlGrp = _fixedAssetDBContext.tFAMtrlGrp.Select(u => new SelectListItem
            {
                Value = u.FAMtrlGrpId.ToString()
                ,
                Text = u.GrpDesc
            });
            ViewBag.MtrlGrp = MtrlGrp;

            VMMtrlSubGrp vMMtrlSubGrp = new() {

                FAMtrlList= MtrlGrp,


            };

            

            return View();
        }

        // POST: MaterialSubGroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MaterialSubGroupController/Edit/5
        public ActionResult Edit(int famtrlSubGrpId)
        {
            return View();
        }

        // POST: MaterialSubGroupController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MaterialSubGroupController/Delete/5
        public ActionResult Delete(int famtrlSubGrpId)
        {
            return View();
        }

        
    }
}
