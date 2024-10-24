using AdminUserEcommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AdminUserEcommerce.ViewComponents
{
    public class LoaiSpMenuViewComponent : ViewComponent
    {
        private readonly ILoaiSpRepository _loaiSpRepository;

        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSpRepository = loaiSpRepository ?? throw new ArgumentNullException(nameof(loaiSpRepository));
        }

        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSpRepository.GetAll().OrderBy(x => x.Loai);
            return View(loaisp);
        }
    }
}
