using System;
using System.Collections.Generic;
using System.Text;

namespace Thi_Thu
{
    class VaccineVn:Vaccine
    {
        public string QuocGia;

        public VaccineVn()
        {
            
        }

        public VaccineVn(string maVc, string tenVc, float thoiGianTacDung, string ngayHetHan, string quocGia) : base(maVc, tenVc, thoiGianTacDung, ngayHetHan)
        {
            QuocGia = quocGia;
        }

        public string QuocGia1
        {
            get => QuocGia;
            set => QuocGia = value;
        }

        public override void InRaManHinh()
        {
            base.InRaManHinh();
            Console.WriteLine(QuocGia);
        }

      
    }
    
}
