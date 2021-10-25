using System;
using System.Collections.Generic;
using System.Text;

namespace Thi_Thu
{
    class Vaccine
    {
        private string MaVC;
        private string TenVC;
        private float ThoiGianTacDung;
        private string NgayHetHan;

        public Vaccine()
        {
            
        }

        public Vaccine(string maVc, string tenVc, float thoiGianTacDung, string ngayHetHan)
        {
            MaVC = maVc;
            TenVC = tenVc;
            ThoiGianTacDung = thoiGianTacDung;
            NgayHetHan = ngayHetHan;
        }

        public string MaVc
        {
            get => MaVC;
            set => MaVC = value;
        }

        public string TenVc
        {
            get => TenVC;
            set => TenVC = value;
        }

        public float ThoiGianTacDung1
        {
            get => ThoiGianTacDung;
            set => ThoiGianTacDung = value;
        }

        public string NgayHetHan1
        {
            get => NgayHetHan;
            set => NgayHetHan = value;
        }

        public virtual void InRaManHinh()
        {
            Console.WriteLine($"{MaVc}|{TenVc}|{ThoiGianTacDung1}|{NgayHetHan1}");
        }
    }
}
