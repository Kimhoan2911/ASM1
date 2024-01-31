// See https://aka.ms/new-console-template for more information
Console.WriteLine("*************chuong trinh tinh hoa don tien nuoc**********");
// khai bao ham xu ly chuong trinh
  void TinhTienHoaDonNuoc()
  {
        Console.WriteLine("Nhap ho ten khach hang : ");
        string customer = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Vui long chon loai khach hang");
        Console.WriteLine("Nhap so 1 neu ban la loai khach hang ho gia dinh");
        Console.WriteLine("Nhap so 2 neu ban la loai khach hang co quan dich vu, hanh chinh cong");
        Console.WriteLine("Nhap so 3 neu ban la loai khach hang don vi san xuat");
        Console.WriteLine("Nhap so 4 neu ban la loai khac hang dich vu kinh doanh");
        int typeCustomer = Convert.ToInt32(Console.ReadLine());
        if (typeCustomer == 1)
        {
            // khach hang ho gia dinh
            // yeu cau nhap so luong thanh vien trong gia dinh
            Console.WriteLine("Nhap so luong thanh vien trong gia dinh");
            int numberMember = Convert.ToInt32(Console.ReadLine());
            if (numberMember >= 1)
            {
                Console.WriteLine("Nhap chi so dong nuoc cua thang truoc");
                int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap chi so dong nuoc cua thang nay");
                int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
                if (waterNumberCurrentMonth >= waterNumberLastMonth)
                {
                    int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                    double waterNumberPeople = waterNumber / numberMember;
                    double money = 0;
                    if (waterNumberPeople > 0 && waterNumber <= 10)
                    {
                        money = waterNumber * 5973 * 1.1;
                    }
                    else if (waterNumberPeople > 10 && waterNumberPeople < 20)
                    {
                        money = waterNumber * 7051 * 1.1;
                    }
                    else if (waterNumberPeople > 20 && waterNumberPeople <= 30)
                    {
                        money = waterNumber * 8699 * 1.1;
                    }
                    else
                    {
                        money = waterNumber * 15929 * 1.1;
                    }
                    Console.WriteLine("Tien nuoc cua gia dinh ban la {0}", money);
                }
                else
                {
                    Console.WriteLine("So nuoc thang truoc khong lon hon thang hien tai");
                }
            }
            else
            {
                Console.WriteLine("Ban khong phai khach hang ho gia dinh");
            }
        }
        else if (typeCustomer == 2)
        {
            // khach hang co quan dich vu, hanh chinh cong
            Console.WriteLine("Vui long nhap chi so dong ho nuoc thang truoc");
            int waterLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui long nhap so dong ho nuoc thang hien tai");
            int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterCurrentMonth > waterLastMonth)
            {
                double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
                Console.WriteLine("Tien nuoc cua co quan hanh chinh cong la {0}", m);
            }
            else
            {
            
            }
        }
        else if (typeCustomer == 3)
        {
            // khach hang don vi san xuat
            Console.WriteLine("Vui long nhap chi so dong ho nuoc thang truoc");
            int waterLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui long nhap so dong ho nuoc thang hien tai");
            int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterCurrentMonth > waterLastMonth)
            {
                double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
                Console.WriteLine("Tien nuoc cua co quan hanh chinh cong la {0}", m);
            }
            else
            {

            }
        }
        else if (typeCustomer == 4)
        {
            // khach hang dich vu kinh doanh
            Console.WriteLine("Vui long nhap chi so dong ho nuoc thang truoc");
            int waterLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui long nhap so dong ho nuoc thang hien tai");
            int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterCurrentMonth > waterLastMonth)
            {
                double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
                Console.WriteLine("Tien nuoc cua co quan hanh chinh cong la {0}", m);


            }
            else
            {

            }
        }
        else
        {
            Console.WriteLine("Vui long nhap dung the loai khach hang");
        }
}
// chay chuong trinnh
TinhTienHoaDonNuoc();