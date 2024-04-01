using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.reposditories
{
    internal class NhanVienreposditories
    {
        private MyContext context;
        public NhanVienreposditories()
        {
            context = new MyContext();
        }

        public List<NhanVien> GetAll()
            //lấy toàn bộ dữ liệu trong bảng nhanvien chuyển vào list
        {
            return context.NhanViens.ToList();
        }

        public bool Update_nv(NhanVien nv)
        {
            if (nv == null) return false;
            context.NhanViens.Update(nv);
            context.SaveChanges();//lưu thay đổi
            return true;
        }

        public bool Them_nv(NhanVien nv)
        {
            if (nv == null) return false;
            context.NhanViens.Add(nv);
            context.SaveChanges();//lưu thay đổi
            return true;
        }

        public bool xoa_nv(NhanVien nv)
        {
            
            if (nv == null) return false;
            context.NhanViens.Remove(nv);
            context.SaveChanges();//lưu thay đổi
            return true;
        }
    }
}
