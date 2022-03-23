using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS2_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bai1();
            //Bai2();
            //Bai3();
            Bai4();
            //Bai5();
            //Bai6();
            //Bai7();
            Console.ReadKey();
        }

        //Bai 1
        static void Bai1()
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine()); ;
            }
            Console.Write("Mang da nhap la: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        //Bai 2
        static void Bai2()
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine()); ;
            }
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.Write("Tong so cac phan tu mang la: {0}", sum);
        }

        //Bai 3
        static void Bai3()
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine()); ;
            }
            Console.Write("Cac phan tu trung nhau trong mang la: ");

            for(int i = 0; i < n; i++)
            {
               int count = 0;
               for(int j = i+1; j < n; j++)
                {
                    int duplicate = 0;
                    for(int k = 0; k < i; k++)
                    {
                        if(arr[k] == arr[i])
                        {
                            duplicate++;
                        }
                    }
                    if(duplicate == 0 && arr[i] == arr[j])
                    {
                        count++;
                    }
                }
               if(count >= 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        //Bai 4
        static void Bai4()
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine()); ;
            }
            //Console.Write("Cac phan tu trung nhau trong mang la: ");
            for(int i = 0; i< n; i++)
            {
                bool isDuplicate = false;
                int count = 0;
                if(i < n - 1)
                {
                    for (int j = i+1; j < n; j++)
                    {
                        for(int k = 0; k < i; k++)
                        {
                            if(arr[k] == arr[i])
                            {
                                isDuplicate= true;
                            }
                        }
                    
                        if(arr[i] == arr[j])
                        {
                            count++;
                        }
                    
                    }
                }
                else
                {
                    for(int k = 0; k < i; k++)
                        {
                            if(arr[k] == arr[i])
                            {
                                isDuplicate= true;
                            }
                        }
                }
                if (!isDuplicate)
                {
                    Console.WriteLine("So lan trung cua {0} la {1}", arr[i], count + 1);
                }
            }
        }

        //Bai 5
        static void Bai5()
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine()); ;
            }
            Console.Write("Mang tang dan: ");
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.Write(arr[i] + " ");
            }
            Console.Write("\nMang giam dan: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.Write(arr[i] + " ");
            }

        }

        //Bai 6
        static void Bai6()
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine()); ;
            }
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            double tbc = (double)sum/arr.Length;
            Console.WriteLine("a. Trung binh cong cua mang la: " + tbc);

            int max = arr[0];
            int index = 0;
            for(int i = 0; i < n; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                    index = i + 1;
                }
            }
            Console.WriteLine("b. Gia tri max la {0}, tai vi tri {1}", max, index);

            Console.Write("Nhap 1 so x bat ky: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            string result = "";
            for(int i = 0; i < n; i++)
            {
                if(arr[i] == x)
                {
                    result += i + 1 + " ";
                    count++;
                }
            }
            if(count > 0)
            {
                Console.Write("Vi tri tim thay cua x trong mang la: {0}", result);
            }
            else
            {
                Console.WriteLine("Khong tim thay x trong mang!");
            }

        }

        //Bai 7
        static void Bai7()
        {
            Console.Write("Nhap so luong hoc sinh can nhap: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[][] students = new string[n][];
            int newNumber = 0;
            string[][] newStudents = new string[newNumber][];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap id cua HS thu {0}: ", i + 1);
                string id = Console.ReadLine();
                Console.Write("Nhap ten cua HS thu {0}: ", i + 1);
                string name = Console.ReadLine();
                Console.Write("Nhap so dien thoai cua HS thu {0}: ", i + 1);
                string phone = Console.ReadLine();
                Console.Write("Nhap dia chi cua HS thu {0}: ", i + 1);
                string address = Console.ReadLine();
                students[i] = new string[] {id, name, phone, address};
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write("Hoc sinh {0}: ", i + 1);
                for(int j = 0; j < students[i].Length; j++)
                {
                    Console.Write(students[i][j] + " | ");
                }
                Console.WriteLine();
            }
            copyStudentsArr(ref n, ref newNumber, ref students, ref newStudents);
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Nhap lua chon cua ban");
                Console.WriteLine("1. Them moi");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Thoat");
                Console.Write("Lua chon: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ThemMoiSV(ref n, ref newNumber, ref students, ref newStudents);
                        break;
                    case 2:
                        CapNhatSinhVien(ref newNumber, ref newStudents);
                        break;
                    case 3:
                        DeleteSinhVien(ref newNumber, ref newStudents);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le! chon lai");
                        break;
                }

            }

            
        }

        static void copyStudentsArr(ref int n, ref int newNumber, ref string[][] students, ref string[][] newStudents)
        {
            newNumber = n;
            newStudents = new string[newNumber][];
            for(int i = 0; i < n; i++)
            {
                newStudents[i] = new string[] { students[i][0], students[i][1], students[i][2], students[i][3]};
            }
        }
        static void HienThiSinhVien(ref int newNumber, ref string[][] newStudents)
        {
            for (int i = 0; i < newNumber; i++)
            {
                Console.Write("Hoc sinh {0}: ", i + 1);
                for (int j = 0; j < newStudents[i].Length; j++)
                {
                    Console.Write(newStudents[i][j] + " | ");
                }
                Console.WriteLine();
            }
        }

        static void ThemMoiSV(ref int n, ref int newNumber, ref string[][] students, ref string[][] newStudents)
        {
            //Them moi sinh vien
            Console.Write("Nhap so luong hoc sinh can them moi: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int tempNumber = newNumber;
            string[][] tempStudents = new string[tempNumber][];
            

            //Copy to temp arr
                for(int i = 0; i < tempNumber; i++)
                {
                    tempStudents[i] = new string[] { newStudents[i][0], newStudents[i][1], newStudents[i][2], newStudents[i][3]};
                }

            newNumber = m + newNumber;
            newStudents = new string[newNumber][];

            for(int i = 0; i < newNumber; i++)
            {
                if(i < tempNumber)
                {
                    newStudents[i] = new string[] { tempStudents[i][0], tempStudents[i][1], tempStudents[i][2], tempStudents[i][3] };
                }
                else
                {
                    Console.Write("Nhap id cua HS thu {0}: ", i + 1);
                    string id = Console.ReadLine();
                    Console.Write("Nhap ten cua HS thu {0}: ", i + 1);
                    string name = Console.ReadLine();
                    Console.Write("Nhap so dien thoai cua HS thu {0}: ", i + 1);
                    string phone = Console.ReadLine();
                    Console.Write("Nhap dia chi cua HS thu {0}: ", i + 1);
                    string address = Console.ReadLine();
                    newStudents[i] = new string[] { id, name, phone, address };

                }
            }

            HienThiSinhVien(ref newNumber, ref newStudents);
        }

        static void CapNhatSinhVien(ref int newNumber, ref string[][] newStudents)
        {
            //Cap nhat thong tin sinh vien theo ID
            Console.Write("Nhap ID sinh vien can sua: ");
            string editId = Console.ReadLine();
            int index = -1;
            for(int i = 0; i < newNumber; i++)
            {
            //Console.WriteLine(newStudents[i][0]);
                if(editId == newStudents[i][0])
                {
                    index = i;
                    //Console.WriteLine(index);
                    break;
                }
            }
            if(index >= 0)
            {
                Console.WriteLine("Sinh vien can sua thong tin la: {0} | {1} | {2} | {3}", newStudents[index][0], newStudents[index][1], newStudents[index][2], newStudents[index][3]);
                Console.Write("Nhap ten can sua cua HS {0}: ", newStudents[index][0]);
                string name = Console.ReadLine();
                Console.Write("Nhap so dien thoai can sua cua HS {0}: ", newStudents[index][0]);
                string phone = Console.ReadLine();
                Console.Write("Nhap dia chi can sua cua HS {0}: ", newStudents[index][0]);
                string address = Console.ReadLine();
                newStudents[index][1] = name;
                newStudents[index][2] = phone;
                newStudents[index][3] = address;
                HienThiSinhVien(ref newNumber, ref newStudents);
            }
            else
            {
                Console.WriteLine("Khong tim thay hoc sinh co id {0}", editId);
            }
            
        }

        static void DeleteSinhVien(ref int newNumber, ref string[][] newStudents)
        {
            Console.Write("Nhap ID sinh vien can xoa: ");
            string deleteId = Console.ReadLine();
            int index = -1;
            string[][] tempStudents = new string[newNumber][];
            for(int i = 0; i < newNumber; i++)
            {
                if(deleteId == newStudents[i][0])
                {
                    index = i;
                    break;
                }
            }
            if(index >= 0)
            {
                //Copy to temp arr
                for(int i = 0; i < newNumber; i++)
                {
                    tempStudents[i] = new string[] { newStudents[i][0], newStudents[i][1], newStudents[i][2], newStudents[i][3]};
                }
                //Remove id
                newNumber = newNumber - 1;
                newStudents = new string[newNumber][];
                for(int i = 0; i < newNumber; i++)
                {
                    int j = i;
                    if(i >= index)
                    {
                        j = i + 1;
                    }
                    newStudents[i] = new string[] { tempStudents[j][0], tempStudents[j][1], tempStudents[j][2], tempStudents[j][3]};
                }
                HienThiSinhVien(ref newNumber, ref newStudents);
            }
            else
            {
                Console.WriteLine("Khong tim thay hoc sinh co id {0}", deleteId);
            }
        }
    }

    
    

}
