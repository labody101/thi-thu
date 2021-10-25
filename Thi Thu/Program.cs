using System;
using System.Text;

namespace Thi_Thu
{
    class Program
    {
        static void Main(string[] args)
        {
            QLVC ss = new QLVC();
            do
            {
                Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
                Console.WriteLine("Chuong trinh Vaccine");
                Console.WriteLine("Moi ban chon chuc nang");
                Console.WriteLine("1.Nhập danh sách đối tượng");
                Console.WriteLine("2.Xuất danh sách đối tượng");
                Console.WriteLine("3.Xuất danh sách các VC  (ThoiGianTacDung >= 6 tháng)");
                Console.WriteLine("4.Sắp xếp giảm dần theo ThoiGianTacDung ");
                Console.WriteLine("5.Kế Thừa");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("Moi ban chon");
                string _input = Console.ReadLine();
                switch (_input)
                {
                    case "1":
                        ss.AddVaccine();
                        break;
                    case "2":
                        ss.GetVaccine();
                        break;
                    case "3":
                        ss.GetIndexVaccine();
                        break;
                    case "4":
                        ss.arrangeVaccine();
                        break;
                    case "5":
                        ss.Kethua();
                        break;
                    case "0":
                        return;
                }
            } while (true);

        }
    }
}
