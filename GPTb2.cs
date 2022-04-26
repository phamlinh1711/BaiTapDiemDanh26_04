using System;
namespace GPTB2 {
 class Program {
 static double a_133, b_133, c_133;
 static double delta_133;
 static double x1_133, x2_133;
 static void NhapABC() {
 String buf;
 Console.Write("Nhập a : "); buf= Console.ReadLine();
 a_133 = Double.Parse(buf);
 Console.Write("Nhập b : "); buf = Console.ReadLine();
 b_133 = Double.Parse(buf);
 Console.Write("Nhập c : "); buf = Console.ReadLine();
 c_133 = Double.Parse(buf);
 }
 static void GiaiPT() {
 delta_133 = b_133 * b_133 - 4 * a_133 * c_133;
 if (delta >= 0) 
 {
 x1_133 = (-b_133 + Math.Sqrt(delta)) / 2 / a_133;
 x2_133 = (-b_133 - Math.Sqrt(delta)) / 2 / a_133;
 }
 } 
 static void XuatKetqua() {
 if (delta_133 < 0)
 Console.WriteLine("Phương trình vô nghiệm");
 else
 {
 Console.WriteLine("Phương trình có 2 nghiệm thực : ");
 Console.WriteLine("X1 = " + x1_133);
 Console.WriteLine("X2 = " + x2_133);
 }
 }

 static void Main(string[] args) {
 NhapABC(); 
 GiaiPT(); 
 XuatKetqua(); 

 Console.Write("Ấn Enter ₫ể dừng chương trình : ");
 Console.Read();
 }
 } 
} 