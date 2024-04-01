using BUS.reposditories;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.service
{
    public class NhanVienService
    {
        private NhanVienreposditories repos;
        public NhanVienService()
        {
            repos = new NhanVienreposditories();
        }

        public List<NhanVien> GetNhanViens(string search)
        {
            if(search==null|| search == string.Empty)
            {
                return repos.GetAll();
            }
            return repos.GetAll().FindAll(x => x.MaNv.Contains(search) || x.HoTen.Contains(search));//trả về toàn bộ danh sách
        }


        public string ThemNV(NhanVien nv)
        {
            if (repos.Them_nv(nv))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string XoaNV(string ma)
        {
            var nv = repos.GetAll().Find(x => x.MaNv == ma);
          if (repos.xoa_nv(nv))
                {
                        return "Xóa thành công";
                 }
                    return "Xóa thất bại";
        }
          
        

        public string update_NV(NhanVien nv)
        {
            if (repos.Update_nv(nv))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
