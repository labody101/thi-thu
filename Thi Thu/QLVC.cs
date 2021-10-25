using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thi_Thu
{
    class QLVC
    {
        private List<Vaccine> _lstVaccine;
        private Vaccine _vaccine;
        private string _input;

        public QLVC()
        {
            _lstVaccine = new List<Vaccine>()
            {
                new Vaccine("abc", "vietnam", 12, "5/10/2020"),
                new Vaccine("xyz","khua",6,"5/3/2022"),
                new Vaccine("mnb","my",24,"5/6/2022")
            };
        }

        public void AddVaccine()
        {
            Console.WriteLine("them vaccine");
            LAI:
            Console.Write("Moi ban nhap so luong Vaccine can nhap:");
            _input = Console.ReadLine();
            
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _vaccine = new Vaccine();
                Console.WriteLine("Moi ban nhap Ten Vaccine:");
                _vaccine.TenVc = Console.ReadLine();
                Console.WriteLine("Moi ban nhap MaVaccine");
                _vaccine.MaVc = Console.ReadLine();
                Console.WriteLine("Moi ban nhap thoi gian tac dung:");
                _vaccine.ThoiGianTacDung1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Moi ban nhap ngay het han:");
                _vaccine.NgayHetHan1 = Console.ReadLine();
                _lstVaccine.Add(_vaccine);
            }
            Console.WriteLine("Them thanh cong");
            Console.WriteLine("Ban muon nhap tiep hay la khong?");
            Console.WriteLine("co(1)\nkhong(2)");
            _input = Console.ReadLine();
            if (Convert.ToInt32(_input)==1)
            {
                goto LAI;
            }
            else
            {
                return;
            }
            Console.WriteLine();
        }

        public void GetVaccine()
        {
            Console.WriteLine("Xuat Vaccine");
            for (int i = 0; i < _lstVaccine.Count; i++)
            {
                _lstVaccine[i].InRaManHinh();    
            }

            Console.WriteLine();
        }

        public void GetIndexVaccine()
        {
            Console.WriteLine("Xuat dsach theo yeu cau");
            for (int i = 0; i < _lstVaccine.Count; i++)
            {
                if (_lstVaccine[i].ThoiGianTacDung1>6)
                {
                    _lstVaccine[i].InRaManHinh();
                }
            }

            Console.WriteLine();
        }

        public void arrangeVaccine()
        {
            cach1:
            var temp = _lstVaccine.OrderByDescending(c => c.ThoiGianTacDung1).ToList();
            _lstVaccine = new List<Vaccine>();
            _lstVaccine = temp;
            Console.WriteLine("Sap xep giam dan thanh cong");
            Console.WriteLine();
            cach2:
            _lstVaccine.Sort((c1,c2)=>c1.ThoiGianTacDung1.CompareTo(c2.ThoiGianTacDung1));
            _lstVaccine.Reverse();
        }
        public void Kethua()
        {
            VaccineVn vn = new VaccineVn();
            vn.MaVc = "123";
            vn.TenVc = "123";
            vn.ThoiGianTacDung1 = 123;
            vn.NgayHetHan1 = "123";
            vn.QuocGia1 = "1234";
            vn.InRaManHinh();
        }
    }
}
